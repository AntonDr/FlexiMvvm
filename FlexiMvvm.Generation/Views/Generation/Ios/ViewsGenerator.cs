﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace FlexiMvvm.Views.Generation.Ios
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ViewsGenerator : ViewsGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 1 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"

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

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Threading.Tasks;\r\nusing FlexiMvvm.ViewModels;\r\nusing " +
                    "FlexiMvvm.ViewModels.Core;\r\nusing FlexiMvvm.Views;\r\nusing FlexiMvvm.Views.Core;\r" +
                    "\nusing FlexiMvvm.Views.Keyboard;\r\n");
            
            #line 26 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
 foreach (var viewGenerationOptions in ViewsGenerationOptions) { 
            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 28 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetNamespace(viewGenerationOptions)));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class ");
            
            #line 30 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 30 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.BaseClassName));
            
            #line default
            #line hidden
            this.Write(@", IView, ILifecycleEventSourceViewController, IKeyboardHandlerOwner
    {
        private IViewLifecycleDelegate _lifecycleDelegate;
        private KeyboardHandler _keyboardHandler;

        public event EventHandler ViewDidLoadCalled;

        public event EventHandler ViewWillAppearCalled;

        public event EventHandler ViewDidAppearCalled;

        public event EventHandler ViewWillDisappearCalled;

        public event EventHandler ViewDidDisappearCalled;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        public virtual bool HandleKeyboard { get; } = ");
            
            #line 47 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.HandleKeyboard.ToString().ToLower()));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n        public KeyboardHandler KeyboardHandler => _keyboardHandler;\r\n\r\n     " +
                    "   protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()\r\n        {" +
                    "\r\n            return new ViewLifecycleDelegate<");
            
            #line 53 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(">(this);\r\n        }\r\n\r\n        public override void ViewDidLoad()\r\n        {\r\n   " +
                    "         base.ViewDidLoad();\r\n\r\n            LifecycleDelegate.ViewDidLoad();\r\n  " +
                    "          ViewDidLoadCalled?.Invoke(this, EventArgs.Empty);\r\n        }\r\n\r\n      " +
                    "  public override void ViewWillAppear(bool animated)\r\n        {\r\n            bas" +
                    "e.ViewWillAppear(animated);\r\n\r\n            LifecycleDelegate.ViewWillAppear();\r\n" +
                    "            ViewWillAppearCalled?.Invoke(this, EventArgs.Empty);\r\n        }\r\n\r\n " +
                    "       public override void ViewDidAppear(bool animated)\r\n        {\r\n           " +
                    " base.ViewDidAppear(animated);\r\n\r\n            ViewDidAppearCalled?.Invoke(this, " +
                    "EventArgs.Empty);\r\n        }\r\n\r\n        public override void ViewWillDisappear(b" +
                    "ool animated)\r\n        {\r\n            base.ViewWillDisappear(animated);\r\n\r\n     " +
                    "       ViewWillDisappearCalled?.Invoke(this, EventArgs.Empty);\r\n        }\r\n\r\n   " +
                    "     public override void ViewDidDisappear(bool animated)\r\n        {\r\n          " +
                    "  base.ViewDidDisappear(animated);\r\n\r\n            LifecycleDelegate.ViewDidDisap" +
                    "pear();\r\n            ViewDidDisappearCalled?.Invoke(this, EventArgs.Empty);\r\n   " +
                    "     }\r\n\r\n        public override void WillMoveToParentViewController(UIViewCont" +
                    "roller parent)\r\n        {\r\n            base.WillMoveToParentViewController(paren" +
                    "t);\r\n\r\n            LifecycleDelegate.WillMoveToParentViewController(parent);\r\n  " +
                    "      }\r\n\r\n        public override void DismissViewController(bool animated, Act" +
                    "ion completionHandler)\r\n        {\r\n            LifecycleDelegate.DismissViewCont" +
                    "roller();\r\n\r\n            base.DismissViewController(animated, completionHandler)" +
                    ";\r\n        }\r\n\r\n        public override Task DismissViewControllerAsync(bool ani" +
                    "mated)\r\n        {\r\n            LifecycleDelegate.DismissViewController();\r\n\r\n   " +
                    "         return base.DismissViewControllerAsync(animated);\r\n        }\r\n\r\n       " +
                    " void IKeyboardHandlerOwner.SetKeyboardHandler(KeyboardHandler handler)\r\n       " +
                    " {\r\n            _keyboardHandler = handler;\r\n        }\r\n    }\r\n\r\n    public part" +
                    "ial class ");
            
            #line 121 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("<TViewModel> : ");
            
            #line 121 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@", INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModel
    {
        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<");
            
            #line 130 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@"<TViewModel>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultSetEventArgs args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            ResultSet?.Invoke(this, args);
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
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

    public partial class ");
            
            #line 172 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("<TViewModel, TParameters> : ");
            
            #line 172 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@", INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithParameters<TParameters>, IParametersOwner<TParameters>
        where TParameters : Parameters
    {
        private readonly TParameters _parameters;

        public ");
            
            #line 178 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@"(TParameters parameters)
        {
            _parameters = parameters;
        }

        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<");
            
            #line 189 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@"<TViewModel, TParameters>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultSetEventArgs args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            ResultSet?.Invoke(this, args);
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
            ViewModel.SetParameters(_parameters);
        }

        Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            return ViewModel.InitializeAsync();
        }
    }
}
");
            
            #line 232 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class ViewsGeneratorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
