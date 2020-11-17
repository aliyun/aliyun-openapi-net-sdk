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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListDiagnoseReportIdsResponseUnmarshaller
    {
        public static ListDiagnoseReportIdsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDiagnoseReportIdsResponse listDiagnoseReportIdsResponse = new ListDiagnoseReportIdsResponse();

			listDiagnoseReportIdsResponse.HttpResponse = _ctx.HttpResponse;
			listDiagnoseReportIdsResponse.RequestId = _ctx.StringValue("ListDiagnoseReportIds.RequestId");

			List<string> listDiagnoseReportIdsResponse_result = new List<string>();
			for (int i = 0; i < _ctx.Length("ListDiagnoseReportIds.Result.Length"); i++) {
				listDiagnoseReportIdsResponse_result.Add(_ctx.StringValue("ListDiagnoseReportIds.Result["+ i +"]"));
			}
			listDiagnoseReportIdsResponse.Result = listDiagnoseReportIdsResponse_result;

			ListDiagnoseReportIdsResponse.ListDiagnoseReportIds_Headers headers = new ListDiagnoseReportIdsResponse.ListDiagnoseReportIds_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListDiagnoseReportIds.Headers.X-Total-Count");
			listDiagnoseReportIdsResponse.Headers = headers;
        
			return listDiagnoseReportIdsResponse;
        }
    }
}
