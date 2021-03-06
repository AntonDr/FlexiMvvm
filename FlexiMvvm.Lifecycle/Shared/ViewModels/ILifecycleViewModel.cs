﻿// =========================================================================
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

using System.Threading.Tasks;

namespace FlexiMvvm.ViewModels
{
    /// <summary>
    /// Defines the contract for a lifecycle-aware view model.
    /// </summary>
    public interface ILifecycleViewModel : IViewModel
    {
    }

    /// <summary>
    /// Defines the contract for a lifecycle-aware view model that takes no parameters.
    /// </summary>
    public interface ILifecycleViewModelWithoutParameters : ILifecycleViewModel
    {
        /// <summary>
        /// An asynchronous lifecycle method for the lifecycle-aware view model initialization.
        /// </summary>
        /// <param name="recreated">Determines whether the view model has been destroyed to recover memory and recreated with a restored state if it was persisted.</param>
        /// <returns>A task that represents the asynchronous initialization operation.</returns>
        Task InitializeAsync(bool recreated);

        /// <summary>
        /// A synchronous lifecycle method for the lifecycle-aware view model initialization.
        /// </summary>
        /// <param name="recreated">Determines whether the view model has been destroyed to recover memory and recreated with a restored state if it was persisted.</param>
        void Initialize(bool recreated);
    }

    /// <summary>
    /// Defines the contract for a lifecycle-aware view model that takes parameters.
    /// </summary>
    /// <typeparam name="TParameters">The type of the view model parameters.</typeparam>
    public interface ILifecycleViewModelWithParameters<TParameters> : ILifecycleViewModel
        where TParameters : Parameters
    {
        /// <summary>
        /// An asynchronous lifecycle method for the lifecycle-aware view model initialization with <paramref name="parameters"/>.
        /// </summary>
        /// <param name="parameters">The view model parameters. Can be <see langword="null"/>.</param>
        /// <param name="recreated">Determines whether the view model has been destroyed to recover memory and recreated with a restored state if it was persisted.</param>
        /// <returns>A task that represents the asynchronous initialization operation.</returns>
        Task InitializeAsync(TParameters? parameters, bool recreated);

        /// <summary>
        /// A synchronous lifecycle method for the lifecycle-aware view model initialization with <paramref name="parameters"/>.
        /// </summary>
        /// <param name="parameters">The view model parameters. Can be <see langword="null"/>.</param>
        /// <param name="recreated">Determines whether the view model has been destroyed to recover memory and recreated with a restored state if it was persisted.</param>
        void Initialize(TParameters? parameters, bool recreated);
    }

    /// <summary>
    /// Defines the contract for a lifecycle-aware view model that returns a result.
    /// </summary>
    /// <typeparam name="TResult">The type of the view model result.</typeparam>
    public interface ILifecycleViewModelWithResult<in TResult> : ILifecycleViewModel
        where TResult : Result
    {
        /// <summary>
        /// Sets the lifecycle-aware view model result.
        /// </summary>
        /// <param name="resultCode">Determines whether the result should be set as successful or not due to cancellation by the user.</param>
        /// <param name="result">The view model result. Can be <see langword="null"/>.</param>
        void SetResult(ResultCode resultCode, TResult? result);
    }

    /// <summary>
    /// Defines the contract for a lifecycle-aware view model that can handle a lifecycle-aware view model result.
    /// </summary>
    public interface ILifecycleViewModelWithResultHandler : ILifecycleViewModel
    {
        /// <summary>
        /// Handles the lifecycle-aware view model result.
        /// </summary>
        /// <param name="resultCode">Determines whether the view model result is set successfully or not due to cancellation by the user.</param>
        /// <param name="result">The view model result to handle. Can be <see langword="null"/>.</param>
        void HandleResult(ResultCode resultCode, Result? result);
    }
}
