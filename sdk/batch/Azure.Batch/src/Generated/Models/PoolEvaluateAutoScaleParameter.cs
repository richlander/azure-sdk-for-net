// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Service.Models
{
    /// <summary> Options for evaluating an automatic scaling formula on a Pool. </summary>
    public partial class PoolEvaluateAutoScaleParameter
    {
        /// <summary> Initializes a new instance of PoolEvaluateAutoScaleParameter. </summary>
        /// <param name="autoScaleFormula"> The formula is validated and its results calculated, but it is not applied to the Pool. To apply the formula to the Pool, &apos;Enable automatic scaling on a Pool&apos;. For more information about specifying this formula, see Automatically scale Compute Nodes in an Azure Batch Pool (https://azure.microsoft.com/en-us/documentation/articles/batch-automatic-scaling). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoScaleFormula"/> is null. </exception>
        public PoolEvaluateAutoScaleParameter(string autoScaleFormula)
        {
            if (autoScaleFormula == null)
            {
                throw new ArgumentNullException(nameof(autoScaleFormula));
            }

            AutoScaleFormula = autoScaleFormula;
        }

        /// <summary> The formula is validated and its results calculated, but it is not applied to the Pool. To apply the formula to the Pool, &apos;Enable automatic scaling on a Pool&apos;. For more information about specifying this formula, see Automatically scale Compute Nodes in an Azure Batch Pool (https://azure.microsoft.com/en-us/documentation/articles/batch-automatic-scaling). </summary>
        public string AutoScaleFormula { get; }
    }
}
