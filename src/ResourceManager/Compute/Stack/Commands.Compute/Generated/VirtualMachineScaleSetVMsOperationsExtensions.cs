// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class VirtualMachineScaleSetVMsOperationsExtensions
    {
            /// <summary>
            /// The operation to re-image a virtual machine scale set instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void Reimage(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).ReimageAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to re-image a virtual machine scale set instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ReimageAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ReimageWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to re-image a virtual machine scale set instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void BeginReimage(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).BeginReimageAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to re-image a virtual machine scale set instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginReimageAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginReimageWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to deallocate a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void Deallocate(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).DeallocateAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to deallocate a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeallocateAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeallocateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to deallocate a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void BeginDeallocate(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).BeginDeallocateAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to deallocate a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeallocateAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeallocateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to delete a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void Delete(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).DeleteAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to delete a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void BeginDelete(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).BeginDeleteAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to get a virtual machine scale set virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static VirtualMachineScaleSetVM Get(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).GetAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get a virtual machine scale set virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineScaleSetVM> GetAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// The operation to get a virtual machine scale set virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static VirtualMachineScaleSetVMInstanceView GetInstanceView(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).GetInstanceViewAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get a virtual machine scale set virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineScaleSetVMInstanceView> GetInstanceViewAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetInstanceViewWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// The operation to list virtual machine scale sets VMs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// The list parameters.
            /// </param>
            public static IPage<VirtualMachineScaleSetVM> List(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string virtualMachineScaleSetName, ODataQuery<VirtualMachineScaleSetVM> odataQuery = default(ODataQuery<VirtualMachineScaleSetVM>), string select = default(string))
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).ListAsync(resourceGroupName, virtualMachineScaleSetName, odataQuery, select), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to list virtual machine scale sets VMs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// The list parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualMachineScaleSetVM>> ListAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string virtualMachineScaleSetName, ODataQuery<VirtualMachineScaleSetVM> odataQuery = default(ODataQuery<VirtualMachineScaleSetVM>), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, virtualMachineScaleSetName, odataQuery, select, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// The operation to power off (stop) a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void PowerOff(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).PowerOffAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to power off (stop) a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PowerOffAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PowerOffWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to power off (stop) a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void BeginPowerOff(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).BeginPowerOffAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to power off (stop) a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPowerOffAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPowerOffWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to restart a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void Restart(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).RestartAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to restart a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RestartAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.RestartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to restart a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void BeginRestart(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).BeginRestartAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to restart a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRestartAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginRestartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to start a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void Start(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).StartAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to start a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StartAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to start a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            public static void BeginStart(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).BeginStartAsync(resourceGroupName, vmScaleSetName, instanceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to start a virtual machine scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance id of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStartAsync( this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to list virtual machine scale sets VMs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualMachineScaleSetVM> ListNext(this IVirtualMachineScaleSetVMsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineScaleSetVMsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to list virtual machine scale sets VMs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualMachineScaleSetVM>> ListNextAsync( this IVirtualMachineScaleSetVMsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

    }
}
