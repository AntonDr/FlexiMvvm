﻿// <auto-generated />
// =========================================================================
// Copyright 2019 EPAM Systems, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// =========================================================================

using System;
using System.Threading.Tasks;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using FlexiMvvm.Persistence.Core;
using FlexiMvvm.ViewModels;
using FlexiMvvm.ViewModels.Core;
using FlexiMvvm.Views;
using FlexiMvvm.Views.Core;

namespace FlexiMvvm.Views
{
    [Register("fleximvvm.views.AppCompatActivity")]
    public partial class AppCompatActivity : Android.Support.V7.App.AppCompatActivity, IAndroidView, ILifecycleEventSourceActivity
    {
        private IViewLifecycleDelegate _lifecycleDelegate;

        public event EventHandler OnCreateCalled;

        public event EventHandler OnStartCalled;

        public event EventHandler OnResumeCalled;

        public event EventHandler OnPauseCalled;

        public event EventHandler OnStopCalled;

        public event EventHandler<OptionsItemSelectedEventArgs> OnOptionsItemSelectedCalled;

        public event EventHandler<BackPressedEventArgs> OnBackPressedCalled;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<AppCompatActivity>(this);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            LifecycleDelegate.OnCreate(savedInstanceState);
            OnCreateCalled?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnStart()
        {
            base.OnStart();

            LifecycleDelegate.OnStart();
            OnStartCalled?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnResume()
        {
            base.OnResume();

            OnResumeCalled?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnPause()
        {
            base.OnPause();

            OnPauseCalled?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnStop()
        {
            base.OnStop();

            OnStopCalled?.Invoke(this, EventArgs.Empty);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            var optionsItemSelectedEventArgs = new OptionsItemSelectedEventArgs(item);
            OnOptionsItemSelectedCalled?.Invoke(this, optionsItemSelectedEventArgs);

            if (optionsItemSelectedEventArgs.Handled)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public override void OnBackPressed()
        {
            var backPressedEventArgs = new BackPressedEventArgs();
            OnBackPressedCalled?.Invoke(this, backPressedEventArgs);

            if (!backPressedEventArgs.Handled)
            {
                base.OnBackPressed();
            }
        }

        protected override void OnActivityResult(int requestCode, Android.App.Result resultCode, Intent data)
        {
            LifecycleDelegate.OnActivityResult(requestCode, (Android.App.Result)resultCode, data);

            base.OnActivityResult(requestCode, resultCode, data);
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            LifecycleDelegate.OnSaveInstanceState(outState);

            base.OnSaveInstanceState(outState);
        }

        protected override void OnDestroy()
        {
            LifecycleDelegate.OnDestroy();

            base.OnDestroy();
        }
    }

    public partial class AppCompatActivity<TViewModel> : AppCompatActivity, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModel, IStateOwner
    {
        private RequestCode _requestCode;

        public TViewModel ViewModel { get; private set; }

        public RequestCode RequestCode => _requestCode ?? (_requestCode = new RequestCode());

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<AppCompatActivity<TViewModel>, TViewModel>(this);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            return ViewModel.InitializeAsync();
        }
    }

    public partial class AppCompatActivity<TViewModel, TParameters> : AppCompatActivity, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithParameters<TParameters>, IParametersOwner<TParameters>, IStateOwner
        where TParameters : Parameters
    {
        private RequestCode _requestCode;

        public TViewModel ViewModel { get; private set; }

        public RequestCode RequestCode => _requestCode ?? (_requestCode = new RequestCode());

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<AppCompatActivity<TViewModel, TParameters>, TViewModel>(this);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            ViewModel.SetParameters(Intent?.GetParameters<TParameters>());

            return ViewModel.InitializeAsync();
        }
    }
}

namespace FlexiMvvm.Views
{
    [Register("fleximvvm.views.Fragment")]
    public partial class Fragment : Android.Support.V4.App.Fragment, IAndroidView, ILifecycleEventSourceFragment
    {
        private IViewLifecycleDelegate _lifecycleDelegate;

        public event EventHandler OnCreateCalled;

        public event EventHandler OnActivityCreatedCalled;

        public event EventHandler OnStartCalled;

        public event EventHandler OnResumeCalled;

        public event EventHandler OnPauseCalled;

        public event EventHandler OnStopCalled;

        public event EventHandler<OptionsItemSelectedEventArgs> OnOptionsItemSelectedCalled;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<Fragment>(this);
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            LifecycleDelegate.OnCreate(savedInstanceState);
            OnCreateCalled?.Invoke(this, EventArgs.Empty);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            OnActivityCreatedCalled?.Invoke(this, EventArgs.Empty);
        }

        public override void OnStart()
        {
            base.OnStart();

            LifecycleDelegate.OnStart();
            OnStartCalled?.Invoke(this, EventArgs.Empty);
        }

        public override void OnResume()
        {
            base.OnResume();

            OnResumeCalled?.Invoke(this, EventArgs.Empty);
        }

        public override void OnPause()
        {
            base.OnPause();

            OnPauseCalled?.Invoke(this, EventArgs.Empty);
        }

        public override void OnStop()
        {
            base.OnStop();

            OnStopCalled?.Invoke(this, EventArgs.Empty);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            var optionsItemSelectedEventArgs = new OptionsItemSelectedEventArgs(item);
            OnOptionsItemSelectedCalled?.Invoke(this, optionsItemSelectedEventArgs);

            if (optionsItemSelectedEventArgs.Handled)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public override void OnActivityResult(int requestCode, int resultCode, Intent data)
        {
            LifecycleDelegate.OnActivityResult(requestCode, (Android.App.Result)resultCode, data);

            base.OnActivityResult(requestCode, resultCode, data);
        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            LifecycleDelegate.OnSaveInstanceState(outState);

            base.OnSaveInstanceState(outState);
        }

        public override void OnDestroyView()
        {
            LifecycleDelegate.OnDestroyView();

            base.OnDestroyView();
        }

        public override void OnDestroy()
        {
            LifecycleDelegate.OnDestroy();

            base.OnDestroy();
        }
    }

    public partial class Fragment<TViewModel> : Fragment, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModel, IStateOwner
    {
        private RequestCode _requestCode;

        public TViewModel ViewModel { get; private set; }

        public RequestCode RequestCode => _requestCode ?? (_requestCode = new RequestCode());

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<Fragment<TViewModel>, TViewModel>(this);
        }

        public void SetResult(Android.App.Result resultCode)
        {
            throw new NotSupportedException();
        }

        public void SetResult(Android.App.Result resultCode, Intent data)
        {
            throw new NotSupportedException();
        }

        public void Finish()
        {
            throw new NotImplementedException();
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            return ViewModel.InitializeAsync();
        }
    }

    public partial class Fragment<TViewModel, TParameters> : Fragment, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithParameters<TParameters>, IParametersOwner<TParameters>, IStateOwner
        where TParameters : Parameters
    {
        private RequestCode _requestCode;

        public TViewModel ViewModel { get; private set; }

        public RequestCode RequestCode => _requestCode ?? (_requestCode = new RequestCode());

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<Fragment<TViewModel, TParameters>, TViewModel>(this);
        }

        public void SetResult(Android.App.Result resultCode)
        {
            throw new NotSupportedException();
        }

        public void SetResult(Android.App.Result resultCode, Intent data)
        {
            throw new NotSupportedException();
        }

        public void Finish()
        {
            throw new NotImplementedException();
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            ViewModel.SetParameters(Arguments?.GetParameters<TParameters>());

            return ViewModel.InitializeAsync();
        }
    }
}

namespace FlexiMvvm.Views
{
    [Register("fleximvvm.views.DialogFragment")]
    public partial class DialogFragment : Android.Support.V4.App.DialogFragment, IAndroidView, ILifecycleEventSourceFragment
    {
        private IViewLifecycleDelegate _lifecycleDelegate;

        public event EventHandler OnCreateCalled;

        public event EventHandler OnActivityCreatedCalled;

        public event EventHandler OnStartCalled;

        public event EventHandler OnResumeCalled;

        public event EventHandler OnPauseCalled;

        public event EventHandler OnStopCalled;

        public event EventHandler<OptionsItemSelectedEventArgs> OnOptionsItemSelectedCalled;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<DialogFragment>(this);
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            LifecycleDelegate.OnCreate(savedInstanceState);
            OnCreateCalled?.Invoke(this, EventArgs.Empty);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            OnActivityCreatedCalled?.Invoke(this, EventArgs.Empty);
        }

        public override void OnStart()
        {
            base.OnStart();

            LifecycleDelegate.OnStart();
            OnStartCalled?.Invoke(this, EventArgs.Empty);
        }

        public override void OnResume()
        {
            base.OnResume();

            OnResumeCalled?.Invoke(this, EventArgs.Empty);
        }

        public override void OnPause()
        {
            base.OnPause();

            OnPauseCalled?.Invoke(this, EventArgs.Empty);
        }

        public override void OnStop()
        {
            base.OnStop();

            OnStopCalled?.Invoke(this, EventArgs.Empty);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            var optionsItemSelectedEventArgs = new OptionsItemSelectedEventArgs(item);
            OnOptionsItemSelectedCalled?.Invoke(this, optionsItemSelectedEventArgs);

            if (optionsItemSelectedEventArgs.Handled)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public override void OnActivityResult(int requestCode, int resultCode, Intent data)
        {
            LifecycleDelegate.OnActivityResult(requestCode, (Android.App.Result)resultCode, data);

            base.OnActivityResult(requestCode, resultCode, data);
        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            LifecycleDelegate.OnSaveInstanceState(outState);

            base.OnSaveInstanceState(outState);
        }

        public override void OnDestroyView()
        {
            LifecycleDelegate.OnDestroyView();

            base.OnDestroyView();
        }

        public override void OnDestroy()
        {
            LifecycleDelegate.OnDestroy();

            base.OnDestroy();
        }
    }

    public partial class DialogFragment<TViewModel> : DialogFragment, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModel, IStateOwner
    {
        private RequestCode _requestCode;

        public TViewModel ViewModel { get; private set; }

        public RequestCode RequestCode => _requestCode ?? (_requestCode = new RequestCode());

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<DialogFragment<TViewModel>, TViewModel>(this);
        }

        public void SetResult(Android.App.Result resultCode)
        {
            throw new NotSupportedException();
        }

        public void SetResult(Android.App.Result resultCode, Intent data)
        {
            throw new NotSupportedException();
        }

        public void Finish()
        {
            throw new NotImplementedException();
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            return ViewModel.InitializeAsync();
        }
    }

    public partial class DialogFragment<TViewModel, TParameters> : DialogFragment, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithParameters<TParameters>, IParametersOwner<TParameters>, IStateOwner
        where TParameters : Parameters
    {
        private RequestCode _requestCode;

        public TViewModel ViewModel { get; private set; }

        public RequestCode RequestCode => _requestCode ?? (_requestCode = new RequestCode());

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<DialogFragment<TViewModel, TParameters>, TViewModel>(this);
        }

        public void SetResult(Android.App.Result resultCode)
        {
            throw new NotSupportedException();
        }

        public void SetResult(Android.App.Result resultCode, Intent data)
        {
            throw new NotSupportedException();
        }

        public void Finish()
        {
            throw new NotImplementedException();
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            ViewModel.SetParameters(Arguments?.GetParameters<TParameters>());

            return ViewModel.InitializeAsync();
        }
    }
}

