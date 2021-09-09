/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.companyreg.Model.V20201022;

namespace Aliyun.Acs.companyreg.Transform.V20201022
{
    public class GetInvoiceInfoResponseUnmarshaller
    {
        public static GetInvoiceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInvoiceInfoResponse getInvoiceInfoResponse = new GetInvoiceInfoResponse();

			getInvoiceInfoResponse.HttpResponse = _ctx.HttpResponse;
			getInvoiceInfoResponse.AcctgPeriod = _ctx.StringValue("GetInvoiceInfo.AcctgPeriod");
			getInvoiceInfoResponse.BaseTotalAmountWithTax = _ctx.StringValue("GetInvoiceInfo.BaseTotalAmountWithTax");
			getInvoiceInfoResponse.BaseTotalAmountWithoutTax = _ctx.StringValue("GetInvoiceInfo.BaseTotalAmountWithoutTax");
			getInvoiceInfoResponse.BaseTotalTax = _ctx.StringValue("GetInvoiceInfo.BaseTotalTax");
			getInvoiceInfoResponse.BizDate = _ctx.LongValue("GetInvoiceInfo.BizDate");
			getInvoiceInfoResponse.Comments = _ctx.StringValue("GetInvoiceInfo.Comments");
			getInvoiceInfoResponse.CreatedStamp = _ctx.LongValue("GetInvoiceInfo.CreatedStamp");
			getInvoiceInfoResponse.DueDate = _ctx.LongValue("GetInvoiceInfo.DueDate");
			getInvoiceInfoResponse.ElecInvoiceUrl = _ctx.StringValue("GetInvoiceInfo.ElecInvoiceUrl");
			getInvoiceInfoResponse.Id = _ctx.LongValue("GetInvoiceInfo.Id");
			getInvoiceInfoResponse.InvoiceCode = _ctx.StringValue("GetInvoiceInfo.InvoiceCode");
			getInvoiceInfoResponse.InvoiceNo = _ctx.StringValue("GetInvoiceInfo.InvoiceNo");
			getInvoiceInfoResponse.IsElectronic = _ctx.BooleanValue("GetInvoiceInfo.IsElectronic");
			getInvoiceInfoResponse.IsAuth = _ctx.BooleanValue("GetInvoiceInfo.IsAuth");
			getInvoiceInfoResponse.IsFee = _ctx.BooleanValue("GetInvoiceInfo.IsFee");
			getInvoiceInfoResponse.OrgName = _ctx.StringValue("GetInvoiceInfo.OrgName");
			getInvoiceInfoResponse.RequestId = _ctx.StringValue("GetInvoiceInfo.RequestId");
			getInvoiceInfoResponse.SimulationCertified = _ctx.BooleanValue("GetInvoiceInfo.SimulationCertified");
			getInvoiceInfoResponse.TaxNo = _ctx.StringValue("GetInvoiceInfo.TaxNo");
			getInvoiceInfoResponse.TaxPct = _ctx.StringValue("GetInvoiceInfo.TaxPct");
			getInvoiceInfoResponse.Type = _ctx.StringValue("GetInvoiceInfo.Type");
			getInvoiceInfoResponse.Payer = _ctx.StringValue("GetInvoiceInfo.Payer");
			getInvoiceInfoResponse.CanUpdate = _ctx.BooleanValue("GetInvoiceInfo.CanUpdate");
			getInvoiceInfoResponse.LabelData = _ctx.StringValue("GetInvoiceInfo.LabelData");

			GetInvoiceInfoResponse.GetInvoiceInfo_BuyMethod buyMethod = new GetInvoiceInfoResponse.GetInvoiceInfo_BuyMethod();
			buyMethod.Key = _ctx.StringValue("GetInvoiceInfo.BuyMethod.Key");
			buyMethod._Value = _ctx.StringValue("GetInvoiceInfo.BuyMethod.Value");
			getInvoiceInfoResponse.BuyMethod = buyMethod;

			GetInvoiceInfoResponse.GetInvoiceInfo_BuyTarget buyTarget = new GetInvoiceInfoResponse.GetInvoiceInfo_BuyTarget();
			buyTarget.Key = _ctx.StringValue("GetInvoiceInfo.BuyTarget.Key");
			buyTarget._Value = _ctx.StringValue("GetInvoiceInfo.BuyTarget.Value");
			getInvoiceInfoResponse.BuyTarget = buyTarget;

			GetInvoiceInfoResponse.GetInvoiceInfo_CustVendorId custVendorId = new GetInvoiceInfoResponse.GetInvoiceInfo_CustVendorId();
			custVendorId.PartyName = _ctx.StringValue("GetInvoiceInfo.CustVendorId.PartyName");
			getInvoiceInfoResponse.CustVendorId = custVendorId;

			GetInvoiceInfoResponse.GetInvoiceInfo_FixedAssetType fixedAssetType = new GetInvoiceInfoResponse.GetInvoiceInfo_FixedAssetType();
			fixedAssetType.Key = _ctx.StringValue("GetInvoiceInfo.FixedAssetType.Key");
			fixedAssetType._Value = _ctx.StringValue("GetInvoiceInfo.FixedAssetType.Value");
			getInvoiceInfoResponse.FixedAssetType = fixedAssetType;

			GetInvoiceInfoResponse.GetInvoiceInfo_IncomeOutType incomeOutType = new GetInvoiceInfoResponse.GetInvoiceInfo_IncomeOutType();
			incomeOutType.Label = _ctx.StringValue("GetInvoiceInfo.IncomeOutType.Label");
			incomeOutType._Value = _ctx.StringValue("GetInvoiceInfo.IncomeOutType.Value");
			getInvoiceInfoResponse.IncomeOutType = incomeOutType;

			GetInvoiceInfoResponse.GetInvoiceInfo_Kind kind = new GetInvoiceInfoResponse.GetInvoiceInfo_Kind();
			kind.Key = _ctx.StringValue("GetInvoiceInfo.Kind.Key");
			kind._Value = _ctx.StringValue("GetInvoiceInfo.Kind.Value");
			getInvoiceInfoResponse.Kind = kind;

			GetInvoiceInfoResponse.GetInvoiceInfo_PayMethod payMethod = new GetInvoiceInfoResponse.GetInvoiceInfo_PayMethod();
			payMethod.Key = _ctx.StringValue("GetInvoiceInfo.PayMethod.Key");
			payMethod._Value = _ctx.StringValue("GetInvoiceInfo.PayMethod.Value");
			getInvoiceInfoResponse.PayMethod = payMethod;

			GetInvoiceInfoResponse.GetInvoiceInfo_ShellMethod shellMethod = new GetInvoiceInfoResponse.GetInvoiceInfo_ShellMethod();
			shellMethod.Key = _ctx.StringValue("GetInvoiceInfo.ShellMethod.Key");
			shellMethod._Value = _ctx.StringValue("GetInvoiceInfo.ShellMethod.Value");
			getInvoiceInfoResponse.ShellMethod = shellMethod;

			GetInvoiceInfoResponse.GetInvoiceInfo_Use use = new GetInvoiceInfoResponse.GetInvoiceInfo_Use();
			use.Key = _ctx.StringValue("GetInvoiceInfo.Use.Key");
			use._Value = _ctx.StringValue("GetInvoiceInfo.Use.Value");
			getInvoiceInfoResponse.Use = use;

			List<GetInvoiceInfoResponse.GetInvoiceInfo_DetailsItem> getInvoiceInfoResponse_details = new List<GetInvoiceInfoResponse.GetInvoiceInfo_DetailsItem>();
			for (int i = 0; i < _ctx.Length("GetInvoiceInfo.Details.Length"); i++) {
				GetInvoiceInfoResponse.GetInvoiceInfo_DetailsItem detailsItem = new GetInvoiceInfoResponse.GetInvoiceInfo_DetailsItem();

				GetInvoiceInfoResponse.GetInvoiceInfo_DetailsItem.GetInvoiceInfo_Product product = new GetInvoiceInfoResponse.GetInvoiceInfo_DetailsItem.GetInvoiceInfo_Product();
				product.Id = _ctx.LongValue("GetInvoiceInfo.Details["+ i +"].Product.Id");
				product.Name = _ctx.StringValue("GetInvoiceInfo.Details["+ i +"].Product.Name");
				detailsItem.Product = product;

				getInvoiceInfoResponse_details.Add(detailsItem);
			}
			getInvoiceInfoResponse.Details = getInvoiceInfoResponse_details;

			List<GetInvoiceInfoResponse.GetInvoiceInfo_AcctgTransList> getInvoiceInfoResponse_voucherTransList = new List<GetInvoiceInfoResponse.GetInvoiceInfo_AcctgTransList>();
			for (int i = 0; i < _ctx.Length("GetInvoiceInfo.VoucherTransList.Length"); i++) {
				GetInvoiceInfoResponse.GetInvoiceInfo_AcctgTransList acctgTransList = new GetInvoiceInfoResponse.GetInvoiceInfo_AcctgTransList();

				GetInvoiceInfoResponse.GetInvoiceInfo_AcctgTransList.GetInvoiceInfo_VoucherTransId voucherTransId = new GetInvoiceInfoResponse.GetInvoiceInfo_AcctgTransList.GetInvoiceInfo_VoucherTransId();
				voucherTransId.Id = _ctx.LongValue("GetInvoiceInfo.VoucherTransList["+ i +"].VoucherTransId.Id");
				voucherTransId.RefVoucherIds = _ctx.StringValue("GetInvoiceInfo.VoucherTransList["+ i +"].VoucherTransId.RefVoucherIds");
				acctgTransList.VoucherTransId = voucherTransId;

				getInvoiceInfoResponse_voucherTransList.Add(acctgTransList);
			}
			getInvoiceInfoResponse.VoucherTransList = getInvoiceInfoResponse_voucherTransList;
        
			return getInvoiceInfoResponse;
        }
    }
}
