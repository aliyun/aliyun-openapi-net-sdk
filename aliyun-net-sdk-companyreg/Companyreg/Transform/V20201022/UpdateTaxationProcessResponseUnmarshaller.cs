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
    public class UpdateTaxationProcessResponseUnmarshaller
    {
        public static UpdateTaxationProcessResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateTaxationProcessResponse updateTaxationProcessResponse = new UpdateTaxationProcessResponse();

			updateTaxationProcessResponse.HttpResponse = _ctx.HttpResponse;
			updateTaxationProcessResponse.DeclareProcessType = _ctx.StringValue("UpdateTaxationProcess.DeclareProcessType");
			updateTaxationProcessResponse.RequestId = _ctx.StringValue("UpdateTaxationProcess.RequestId");

			List<UpdateTaxationProcessResponse.UpdateTaxationProcess_TaxItemDetailListItem> updateTaxationProcessResponse_taxItemDetailList = new List<UpdateTaxationProcessResponse.UpdateTaxationProcess_TaxItemDetailListItem>();
			for (int i = 0; i < _ctx.Length("UpdateTaxationProcess.TaxItemDetailList.Length"); i++) {
				UpdateTaxationProcessResponse.UpdateTaxationProcess_TaxItemDetailListItem taxItemDetailListItem = new UpdateTaxationProcessResponse.UpdateTaxationProcess_TaxItemDetailListItem();
				taxItemDetailListItem.Id = _ctx.LongValue("UpdateTaxationProcess.TaxItemDetailList["+ i +"].Id");
				taxItemDetailListItem.IsDeclared = _ctx.BooleanValue("UpdateTaxationProcess.TaxItemDetailList["+ i +"].IsDeclared");
				taxItemDetailListItem.IsDeclaredThisPeriod = _ctx.BooleanValue("UpdateTaxationProcess.TaxItemDetailList["+ i +"].IsDeclaredThisPeriod");
				taxItemDetailListItem.IsPaid = _ctx.BooleanValue("UpdateTaxationProcess.TaxItemDetailList["+ i +"].IsPaid");
				taxItemDetailListItem.TaxAmount = _ctx.StringValue("UpdateTaxationProcess.TaxItemDetailList["+ i +"].TaxAmount");
				taxItemDetailListItem.TaxTypeId = _ctx.IntegerValue("UpdateTaxationProcess.TaxItemDetailList["+ i +"].TaxTypeId");
				taxItemDetailListItem.TaxTypeName = _ctx.StringValue("UpdateTaxationProcess.TaxItemDetailList["+ i +"].TaxTypeName");

				updateTaxationProcessResponse_taxItemDetailList.Add(taxItemDetailListItem);
			}
			updateTaxationProcessResponse.TaxItemDetailList = updateTaxationProcessResponse_taxItemDetailList;
        
			return updateTaxationProcessResponse;
        }
    }
}
