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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.TeslaMaxCompute.Model.V20180104;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Transform.V20180104
{
    public class ListUserQuotasResponseUnmarshaller
    {
        public static ListUserQuotasResponse Unmarshall(UnmarshallerContext context)
        {
			ListUserQuotasResponse listUserQuotasResponse = new ListUserQuotasResponse();

			listUserQuotasResponse.HttpResponse = context.HttpResponse;
			listUserQuotasResponse.RequestId = context.StringValue("ListUserQuotas.RequestId");
			listUserQuotasResponse.Message = context.StringValue("ListUserQuotas.Message");
			listUserQuotasResponse.Code = context.IntegerValue("ListUserQuotas.Code");

			ListUserQuotasResponse.ListUserQuotas_Data data = new ListUserQuotasResponse.ListUserQuotas_Data();

			ListUserQuotasResponse.ListUserQuotas_Data.ListUserQuotas_Error error = new ListUserQuotasResponse.ListUserQuotas_Data.ListUserQuotas_Error();
			error.Code = context.StringValue("ListUserQuotas.Data.Error.Code");
			error.Message = context.StringValue("ListUserQuotas.Data.Error.Message");
			error.Timestamp = context.StringValue("ListUserQuotas.Data.Error.Timestamp");
			data.Error = error;

			List<ListUserQuotasResponse.ListUserQuotas_Data.ListUserQuotas_Quotas> data_detail = new List<ListUserQuotasResponse.ListUserQuotas_Data.ListUserQuotas_Quotas>();
			for (int i = 0; i < context.Length("ListUserQuotas.Data.Detail.Length"); i++) {
				ListUserQuotasResponse.ListUserQuotas_Data.ListUserQuotas_Quotas quotas = new ListUserQuotasResponse.ListUserQuotas_Data.ListUserQuotas_Quotas();
				quotas.Quotaid = context.LongValue("ListUserQuotas.Data.Detail["+ i +"].Quotaid");
				quotas.Cluster = context.StringValue("ListUserQuotas.Data.Detail["+ i +"].Cluster");
				quotas.Region = context.StringValue("ListUserQuotas.Data.Detail["+ i +"].Region");
				quotas.Name = context.StringValue("ListUserQuotas.Data.Detail["+ i +"].Name");
				quotas.Parentid = context.LongValue("ListUserQuotas.Data.Detail["+ i +"].Parentid");
				quotas.Nick = context.StringValue("ListUserQuotas.Data.Detail["+ i +"].Nick");

				data_detail.Add(quotas);
			}
			data.Detail = data_detail;
			listUserQuotasResponse.Data = data;
        
			return listUserQuotasResponse;
        }
    }
}