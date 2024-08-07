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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class DataSourceBloodResponseUnmarshaller
    {
        public static DataSourceBloodResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DataSourceBloodResponse dataSourceBloodResponse = new DataSourceBloodResponse();

			dataSourceBloodResponse.HttpResponse = _ctx.HttpResponse;
			dataSourceBloodResponse.RequestId = _ctx.StringValue("DataSourceBlood.RequestId");
			dataSourceBloodResponse.Success = _ctx.BooleanValue("DataSourceBlood.Success");

			List<string> dataSourceBloodResponse_result = new List<string>();
			for (int i = 0; i < _ctx.Length("DataSourceBlood.Result.Length"); i++) {
				dataSourceBloodResponse_result.Add(_ctx.StringValue("DataSourceBlood.Result["+ i +"]"));
			}
			dataSourceBloodResponse.Result = dataSourceBloodResponse_result;
        
			return dataSourceBloodResponse;
        }
    }
}
