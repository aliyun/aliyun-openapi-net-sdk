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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DoQuickFieldResponseUnmarshaller
    {
        public static DoQuickFieldResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DoQuickFieldResponse doQuickFieldResponse = new DoQuickFieldResponse();

			doQuickFieldResponse.HttpResponse = _ctx.HttpResponse;
			doQuickFieldResponse.Success = _ctx.BooleanValue("DoQuickField.Success");
			doQuickFieldResponse.Code = _ctx.IntegerValue("DoQuickField.Code");
			doQuickFieldResponse.Message = _ctx.StringValue("DoQuickField.Message");
			doQuickFieldResponse.ErrCode = _ctx.StringValue("DoQuickField.ErrCode");
			doQuickFieldResponse.RequestId = _ctx.StringValue("DoQuickField.RequestId");
			doQuickFieldResponse.DyCode = _ctx.StringValue("DoQuickField.DyCode");
			doQuickFieldResponse.DyMessage = _ctx.StringValue("DoQuickField.DyMessage");

			DoQuickFieldResponse.DoQuickField_Data data = new DoQuickFieldResponse.DoQuickField_Data();
			data.QueryMode = _ctx.IntegerValue("DoQuickField.Data.QueryMode");
			data.Limited = _ctx.LongValue("DoQuickField.Data.Limited");
			data.Count = _ctx.IntegerValue("DoQuickField.Data.Count");
			data.HasSQL = _ctx.BooleanValue("DoQuickField.Data.HasSQL");
			data.WhereQuery = _ctx.StringValue("DoQuickField.Data.WhereQuery");
			data.PQuery = _ctx.StringValue("DoQuickField.Data.PQuery");
			data.ProcessedRows = _ctx.LongValue("DoQuickField.Data.ProcessedRows");
			data.CompleteOrNot = _ctx.BooleanValue("DoQuickField.Data.CompleteOrNot");
			data.AggQueryd = _ctx.StringValue("DoQuickField.Data.AggQueryd");

			List<string> data_keys = new List<string>();
			for (int i = 0; i < _ctx.Length("DoQuickField.Data.Keys.Length"); i++) {
				data_keys.Add(_ctx.StringValue("DoQuickField.Data.Keys["+ i +"]"));
			}
			data.Keys = data_keys;

			List<string> data_logs = new List<string>();
			for (int i = 0; i < _ctx.Length("DoQuickField.Data.Logs.Length"); i++) {
				data_logs.Add(_ctx.StringValue("DoQuickField.Data.Logs["+ i +"]"));
			}
			data.Logs = data_logs;
			doQuickFieldResponse.Data = data;
        
			return doQuickFieldResponse;
        }
    }
}
