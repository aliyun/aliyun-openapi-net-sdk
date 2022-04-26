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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ExportDoNotCallNumbersResponseUnmarshaller
    {
        public static ExportDoNotCallNumbersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExportDoNotCallNumbersResponse exportDoNotCallNumbersResponse = new ExportDoNotCallNumbersResponse();

			exportDoNotCallNumbersResponse.HttpResponse = _ctx.HttpResponse;
			exportDoNotCallNumbersResponse.HttpStatusCode = _ctx.IntegerValue("ExportDoNotCallNumbers.HttpStatusCode");
			exportDoNotCallNumbersResponse.Code = _ctx.StringValue("ExportDoNotCallNumbers.Code");
			exportDoNotCallNumbersResponse.Message = _ctx.StringValue("ExportDoNotCallNumbers.Message");
			exportDoNotCallNumbersResponse.Data = _ctx.StringValue("ExportDoNotCallNumbers.Data");
			exportDoNotCallNumbersResponse.RequestId = _ctx.StringValue("ExportDoNotCallNumbers.RequestId");

			List<string> exportDoNotCallNumbersResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ExportDoNotCallNumbers.Params.Length"); i++) {
				exportDoNotCallNumbersResponse_params.Add(_ctx.StringValue("ExportDoNotCallNumbers.Params["+ i +"]"));
			}
			exportDoNotCallNumbersResponse._Params = exportDoNotCallNumbersResponse_params;
        
			return exportDoNotCallNumbersResponse;
        }
    }
}
