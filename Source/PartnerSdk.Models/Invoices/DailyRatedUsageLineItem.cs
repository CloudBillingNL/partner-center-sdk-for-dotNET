﻿// -----------------------------------------------------------------------
// <copyright file="DailyRatedUsageLineItem.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.Models.Invoices
{
    using System;

    /// <summary>
    /// Represents unbilled, billed reconciliation line items for daily rated usage.
    /// </summary>
    public class DailyRatedUsageLineItem : InvoiceLineItem
    {
        /// <summary>
        /// Gets or sets the partner Id.
        /// </summary>
        public string PartnerId { get; set; }

        /// <summary>
        /// Gets or sets the partner name.
        /// </summary>
        public string PartnerName { get; set; }

        /// <summary>
        /// Gets or sets the id of the customer that usage belongs to.
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer company that usage belongs to.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the domain name of the customer that usage belongs to.
        /// </summary>
        public string CustomerDomainName { get; set; }

        /// <summary>
        /// Gets or sets the id of the invoice that usage belongs to.
        /// </summary>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or sets the product unique identifier
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets the sku unique identifier
        /// </summary>
        public string SkuId { get; set; }

        /// <summary>
        /// Gets or sets the availability unique identifier
        /// </summary>
        public string AvailabilityId { get; set; }

        /// <summary>
        /// Gets or sets the SKU name for the service.
        /// </summary>
        public string SkuName { get; set; }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the name of publisher.
        /// </summary>
        public string PublisherName { get; set; }

        /// <summary>
        /// Gets or sets the id of the publisher.
        /// </summary>
        public string PublisherId { get; set; }

        /// <summary>
        /// Gets or sets the subscription id.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the subscription description.
        /// </summary>
        public string SubscriptionDescription { get; set; }

        /// <summary>
        /// Gets or sets the charge start date.
        /// </summary>
        public DateTime ChargeStartDate { get; set; }

        /// <summary>
        /// Gets or sets the charge end date.
        /// </summary>
        public DateTime ChargeEndDate { get; set; }

        /// <summary>
        /// Gets or sets the usage date.
        /// </summary>
        public DateTime UsageDate { get; set; }

        /// <summary>
        /// Gets or sets the meter type.
        /// </summary>
        public string MeterType { get; set; }

        /// <summary>
        /// Gets or sets the meter category.
        /// </summary>
        public string MeterCategory { get; set; }

        /// <summary>
        /// Gets or sets the  meter id (GUID).
        /// </summary>
        public string MeterId { get; set; }

        /// <summary>
        /// Gets or sets the meter sub category.
        /// </summary>
        public string MeterSubCategory { get; set; }

        /// <summary>
        /// Gets or sets the meter name.
        /// </summary>
        public string MeterName { get; set; }

        /// <summary>
        /// Gets or sets the meter region.
        /// </summary>
        public string MeterRegion { get; set; }

        /// <summary>
        /// Gets or sets the unit of measure.
        /// </summary>
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Gets or sets the location of resource.
        /// </summary>
        public string ResourceLocation { get; set; }

        /// <summary>
        /// Gets or sets the consumed service name.
        /// </summary>
        public string ConsumedService { get; set; }

        /// <summary>
        /// Gets or sets the name of resource group.
        /// </summary>
        public string ResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets the uri of the resource instance that the usage is about.
        /// </summary>
        public string ResourceUri { get; set; }

        /// <summary>
        /// Gets or sets the customer added tags. For more information, see Organize your Azure resources with tags.
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// Gets or sets the service-specific metadata. For example, an image type for a virtual machine.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Gets or sets internal Azure Service Metadata.
        /// </summary>
        public string ServiceInfo1 { get; set; }

        /// <summary>
        /// Gets or sets service information for example, an image type for a virtual machine and ISP name for ExpressRoute.
        /// </summary>
        public string ServiceInfo2 { get; set; }

        /// <summary>
        /// Gets or sets the country of the customer.
        /// </summary>
        public string CustomerCountry { get; set; }

        /// <summary>
        /// Gets or sets the MPN Id associated to this line item.
        /// </summary>
        public string MpnId { get; set; }

        /// <summary>
        /// Gets or sets the Reseller MPN Id of the Tier 2 partner associated to this line item.
        /// </summary>
        public string ResellerMpnId { get; set; }

        /// <summary>
        /// Gets or sets the type of charge.
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// Gets or sets the price of unit.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the quantity of usage.
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit type like 1 Hour.
        /// </summary>
        public string UnitType { get; set; }

        /// <summary>
        /// Gets or sets the extended cost or total cost before tax in local currency of the customer or billing currency.
        /// </summary>
        public decimal BillingPreTaxTotal { get; set; }

        /// <summary>
        /// Gets or sets ISO currency in which the meter is charged in local currency of the customer or billing currency.
        /// </summary>
        public string BillingCurrency { get; set; }

        /// <summary>
        /// Gets or sets the extended cost or total cost before tax in USD or catalog currency used for rating.
        /// </summary>
        public decimal PricingPreTaxTotal { get; set; }

        /// <summary>
        /// Gets or sets ISO currency in which the meter is charged in USD or catalog currency used for rating.
        /// </summary>
        public string PricingCurrency { get; set; }

        /// <summary>
        /// Gets or sets the entitlement (azure's subscription) id.
        /// </summary>
        public string EntitlementId { get; set; }

        /// <summary>
        /// Gets or sets the entitlement (azure's subscription) description.
        /// </summary>
        public string EntitlementDescription { get; set; }

        /// <summary>
        /// Gets or sets the pricing currency to billing currency exchange rate.
        /// </summary>
        public decimal PCToBCExchangeRate { get; set; }

        /// <summary>
        /// Gets or sets the pricing currency to billing currency exchange rate date.
        /// </summary>
        public DateTime? PCToBCExchangeRateDate { get; set; }

        /// <summary>
        /// Gets or sets the effective unit price.
        /// </summary>
        public decimal EffectiveUnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the rate of partner earned credit.
        /// </summary>
        public decimal RateOfPartnerEarnedCredit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the partner earned credit is applied.
        /// </summary>
        public bool HasPartnerEarnedCredit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the type of credit.
        /// </summary>
        public string CreditType { get; set; }

        /// <summary>
        /// Gets or sets a the rate of credit.
        /// </summary>
        public decimal? RateOfCredit { get; set; }

        /// <summary>
        /// Returns the type of invoice line item
        /// </summary>
        /// <returns>The type of invoice line item.</returns>
        public override InvoiceLineItemType InvoiceLineItemType
        {
            get { return InvoiceLineItemType.UsageLineItems; }
        }

        /// <summary>
        /// Returns the billing provider
        /// </summary>
        /// <returns>The billing provider.</returns>
        public override BillingProvider BillingProvider
        {
            get { return BillingProvider.Marketplace; }
        }

        /// <summary>
        /// A unique identifier for each Azure Savings Plan.
        /// </summary>
        public string BenefitOrderId { get; set; }

        /// <summary>
        /// A unique identifier, which is similar to the Azure reservation order ID. You can match this with the ReservationOrderID on the invoice reconciliation to link the monthly cost to the daily charges.
        /// </summary>
        public string BenefitId { get; set; }

        /// <summary>
        /// It has the value “SavingsPlan” to make it easy to find Azure Savings Plan transactions.
        /// </summary>
        public BenefitType BenefitType { get; set; }
    }
}