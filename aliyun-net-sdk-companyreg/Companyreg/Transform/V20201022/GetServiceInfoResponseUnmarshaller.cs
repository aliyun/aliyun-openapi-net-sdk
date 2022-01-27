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
    public class GetServiceInfoResponseUnmarshaller
    {
        public static GetServiceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceInfoResponse getServiceInfoResponse = new GetServiceInfoResponse();

			getServiceInfoResponse.HttpResponse = _ctx.HttpResponse;
			getServiceInfoResponse.RequestId = _ctx.StringValue("GetServiceInfo.RequestId");
			getServiceInfoResponse.OpeningPeriod = _ctx.StringValue("GetServiceInfo.OpeningPeriod");
			getServiceInfoResponse.CurrentPeriod = _ctx.StringValue("GetServiceInfo.CurrentPeriod");
			getServiceInfoResponse.SystemTime = _ctx.LongValue("GetServiceInfo.SystemTime");
			getServiceInfoResponse.IsClearedTrialData = _ctx.BooleanValue("GetServiceInfo.IsClearedTrialData");
			getServiceInfoResponse.Name = _ctx.StringValue("GetServiceInfo.Name");
			getServiceInfoResponse.OpeningBalanceStatus = _ctx.StringValue("GetServiceInfo.OpeningBalanceStatus");

			GetServiceInfoResponse.GetServiceInfo_InvoiceCheckControlledInfo invoiceCheckControlledInfo = new GetServiceInfoResponse.GetServiceInfo_InvoiceCheckControlledInfo();
			invoiceCheckControlledInfo.MonthCheckCount = _ctx.IntegerValue("GetServiceInfo.InvoiceCheckControlledInfo.MonthCheckCount");
			invoiceCheckControlledInfo.MonthLimitCount = _ctx.IntegerValue("GetServiceInfo.InvoiceCheckControlledInfo.MonthLimitCount");
			invoiceCheckControlledInfo.TrialLimitCount = _ctx.IntegerValue("GetServiceInfo.InvoiceCheckControlledInfo.TrialLimitCount");
			invoiceCheckControlledInfo.IsControlledByLimit = _ctx.BooleanValue("GetServiceInfo.InvoiceCheckControlledInfo.IsControlledByLimit");
			getServiceInfoResponse.InvoiceCheckControlledInfo = invoiceCheckControlledInfo;
        
			return getServiceInfoResponse;
        }
    }
}
