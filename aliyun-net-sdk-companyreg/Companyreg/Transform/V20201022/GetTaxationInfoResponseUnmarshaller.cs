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
    public class GetTaxationInfoResponseUnmarshaller
    {
        public static GetTaxationInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaxationInfoResponse getTaxationInfoResponse = new GetTaxationInfoResponse();

			getTaxationInfoResponse.HttpResponse = _ctx.HttpResponse;
			getTaxationInfoResponse.DeclareProcessType = _ctx.StringValue("GetTaxationInfo.DeclareProcessType");
			getTaxationInfoResponse.RequestId = _ctx.StringValue("GetTaxationInfo.RequestId");

			List<GetTaxationInfoResponse.GetTaxationInfo_TaxItemDetailListItem> getTaxationInfoResponse_taxItemDetailList = new List<GetTaxationInfoResponse.GetTaxationInfo_TaxItemDetailListItem>();
			for (int i = 0; i < _ctx.Length("GetTaxationInfo.TaxItemDetailList.Length"); i++) {
				GetTaxationInfoResponse.GetTaxationInfo_TaxItemDetailListItem taxItemDetailListItem = new GetTaxationInfoResponse.GetTaxationInfo_TaxItemDetailListItem();
				taxItemDetailListItem.Id = _ctx.LongValue("GetTaxationInfo.TaxItemDetailList["+ i +"].Id");
				taxItemDetailListItem.IsDeclaredThisPeriod = _ctx.BooleanValue("GetTaxationInfo.TaxItemDetailList["+ i +"].IsDeclaredThisPeriod");
				taxItemDetailListItem.IsDeclared = _ctx.BooleanValue("GetTaxationInfo.TaxItemDetailList["+ i +"].IsDeclared");
				taxItemDetailListItem.IsPaid = _ctx.BooleanValue("GetTaxationInfo.TaxItemDetailList["+ i +"].IsPaid");
				taxItemDetailListItem.TaxAmount = _ctx.StringValue("GetTaxationInfo.TaxItemDetailList["+ i +"].TaxAmount");
				taxItemDetailListItem.TaxTypeId = _ctx.IntegerValue("GetTaxationInfo.TaxItemDetailList["+ i +"].TaxTypeId");
				taxItemDetailListItem.TaxTypeName = _ctx.StringValue("GetTaxationInfo.TaxItemDetailList["+ i +"].TaxTypeName");

				getTaxationInfoResponse_taxItemDetailList.Add(taxItemDetailListItem);
			}
			getTaxationInfoResponse.TaxItemDetailList = getTaxationInfoResponse_taxItemDetailList;
        
			return getTaxationInfoResponse;
        }
    }
}
