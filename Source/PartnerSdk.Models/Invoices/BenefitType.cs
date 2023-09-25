//----------------------------------------------------------------
// <copyright file="BillingProvider.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
//----------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.Models.Invoices
{
    using Microsoft.Store.PartnerCenter.Models.JsonConverters;
    using Newtonsoft.Json;

    [JsonConverter(typeof(EnumJsonConverter))]
    public enum BenefitType
    {
        /// <summary>
        /// Enum initializer.
        /// </summary>
        None,

        Charge,

        /// <summary>
        /// Azure Savings Plan transactions.
        /// </summary>
        SavingsPlan,
    }
}
