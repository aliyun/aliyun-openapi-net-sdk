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
    public class GetTypeListResponseUnmarshaller
    {
        public static GetTypeListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTypeListResponse getTypeListResponse = new GetTypeListResponse();

			getTypeListResponse.HttpResponse = _ctx.HttpResponse;
			getTypeListResponse.RequestId = _ctx.StringValue("GetTypeList.RequestId");

			GetTypeListResponse.GetTypeList_Fee fee = new GetTypeListResponse.GetTypeList_Fee();

			List<GetTypeListResponse.GetTypeList_Fee.GetTypeList_KindEnum> fee_kind = new List<GetTypeListResponse.GetTypeList_Fee.GetTypeList_KindEnum>();
			for (int i = 0; i < _ctx.Length("GetTypeList.Fee.Kind.Length"); i++) {
				GetTypeListResponse.GetTypeList_Fee.GetTypeList_KindEnum kindEnum = new GetTypeListResponse.GetTypeList_Fee.GetTypeList_KindEnum();
				kindEnum.Key = _ctx.StringValue("GetTypeList.Fee.Kind["+ i +"].Key");
				kindEnum._Value = _ctx.StringValue("GetTypeList.Fee.Kind["+ i +"].Value");

				fee_kind.Add(kindEnum);
			}
			fee.Kind = fee_kind;

			List<GetTypeListResponse.GetTypeList_Fee.GetTypeList_PayMethodEnum> fee_payMethod = new List<GetTypeListResponse.GetTypeList_Fee.GetTypeList_PayMethodEnum>();
			for (int i = 0; i < _ctx.Length("GetTypeList.Fee.PayMethod.Length"); i++) {
				GetTypeListResponse.GetTypeList_Fee.GetTypeList_PayMethodEnum payMethodEnum = new GetTypeListResponse.GetTypeList_Fee.GetTypeList_PayMethodEnum();
				payMethodEnum.Key = _ctx.StringValue("GetTypeList.Fee.PayMethod["+ i +"].Key");
				payMethodEnum._Value = _ctx.StringValue("GetTypeList.Fee.PayMethod["+ i +"].Value");

				fee_payMethod.Add(payMethodEnum);
			}
			fee.PayMethod = fee_payMethod;

			List<GetTypeListResponse.GetTypeList_Fee.GetTypeList_UseEnum> fee_use = new List<GetTypeListResponse.GetTypeList_Fee.GetTypeList_UseEnum>();
			for (int i = 0; i < _ctx.Length("GetTypeList.Fee.Use.Length"); i++) {
				GetTypeListResponse.GetTypeList_Fee.GetTypeList_UseEnum useEnum = new GetTypeListResponse.GetTypeList_Fee.GetTypeList_UseEnum();
				useEnum.Key = _ctx.StringValue("GetTypeList.Fee.Use["+ i +"].Key");
				useEnum._Value = _ctx.StringValue("GetTypeList.Fee.Use["+ i +"].Value");

				fee_use.Add(useEnum);
			}
			fee.Use = fee_use;
			getTypeListResponse.Fee = fee;

			GetTypeListResponse.GetTypeList_InInvoice inInvoice = new GetTypeListResponse.GetTypeList_InInvoice();

			List<GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_BuyMethodEnum> inInvoice_buyMethod = new List<GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_BuyMethodEnum>();
			for (int i = 0; i < _ctx.Length("GetTypeList.InInvoice.BuyMethod.Length"); i++) {
				GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_BuyMethodEnum buyMethodEnum = new GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_BuyMethodEnum();
				buyMethodEnum.Key = _ctx.StringValue("GetTypeList.InInvoice.BuyMethod["+ i +"].Key");
				buyMethodEnum._Value = _ctx.StringValue("GetTypeList.InInvoice.BuyMethod["+ i +"].Value");

				inInvoice_buyMethod.Add(buyMethodEnum);
			}
			inInvoice.BuyMethod = inInvoice_buyMethod;

			List<GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_FixedAssetTypeEnum> inInvoice_fixedAssetType = new List<GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_FixedAssetTypeEnum>();
			for (int i = 0; i < _ctx.Length("GetTypeList.InInvoice.FixedAssetType.Length"); i++) {
				GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_FixedAssetTypeEnum fixedAssetTypeEnum = new GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_FixedAssetTypeEnum();
				fixedAssetTypeEnum.Key = _ctx.StringValue("GetTypeList.InInvoice.FixedAssetType["+ i +"].Key");
				fixedAssetTypeEnum._Value = _ctx.StringValue("GetTypeList.InInvoice.FixedAssetType["+ i +"].Value");

				inInvoice_fixedAssetType.Add(fixedAssetTypeEnum);
			}
			inInvoice.FixedAssetType = inInvoice_fixedAssetType;

			List<GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_BuyTargetEnum> inInvoice_buyTarget = new List<GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_BuyTargetEnum>();
			for (int i = 0; i < _ctx.Length("GetTypeList.InInvoice.BuyTarget.Length"); i++) {
				GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_BuyTargetEnum buyTargetEnum = new GetTypeListResponse.GetTypeList_InInvoice.GetTypeList_BuyTargetEnum();
				buyTargetEnum.Key = _ctx.StringValue("GetTypeList.InInvoice.BuyTarget["+ i +"].Key");
				buyTargetEnum._Value = _ctx.StringValue("GetTypeList.InInvoice.BuyTarget["+ i +"].Value");

				inInvoice_buyTarget.Add(buyTargetEnum);
			}
			inInvoice.BuyTarget = inInvoice_buyTarget;
			getTypeListResponse.InInvoice = inInvoice;

			GetTypeListResponse.GetTypeList_OutInvoice outInvoice = new GetTypeListResponse.GetTypeList_OutInvoice();

			List<GetTypeListResponse.GetTypeList_OutInvoice.GetTypeList_ShellMethodEnum> outInvoice_shellMethod = new List<GetTypeListResponse.GetTypeList_OutInvoice.GetTypeList_ShellMethodEnum>();
			for (int i = 0; i < _ctx.Length("GetTypeList.OutInvoice.ShellMethod.Length"); i++) {
				GetTypeListResponse.GetTypeList_OutInvoice.GetTypeList_ShellMethodEnum shellMethodEnum = new GetTypeListResponse.GetTypeList_OutInvoice.GetTypeList_ShellMethodEnum();
				shellMethodEnum.Key = _ctx.StringValue("GetTypeList.OutInvoice.ShellMethod["+ i +"].Key");
				shellMethodEnum._Value = _ctx.StringValue("GetTypeList.OutInvoice.ShellMethod["+ i +"].Value");

				outInvoice_shellMethod.Add(shellMethodEnum);
			}
			outInvoice.ShellMethod = outInvoice_shellMethod;
			getTypeListResponse.OutInvoice = outInvoice;
        
			return getTypeListResponse;
        }
    }
}
