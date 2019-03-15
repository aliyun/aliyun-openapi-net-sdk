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
using Aliyun.Acs.CloudPhoto.Model.V20170711;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class MergeFacesResponseUnmarshaller
    {
        public static MergeFacesResponse Unmarshall(UnmarshallerContext context)
        {
			MergeFacesResponse mergeFacesResponse = new MergeFacesResponse();

			mergeFacesResponse.HttpResponse = context.HttpResponse;
			mergeFacesResponse.Code = context.StringValue("MergeFaces.Code");
			mergeFacesResponse.Message = context.StringValue("MergeFaces.Message");
			mergeFacesResponse.RequestId = context.StringValue("MergeFaces.RequestId");
			mergeFacesResponse.Action = context.StringValue("MergeFaces.Action");

			List<MergeFacesResponse.MergeFaces_Result> mergeFacesResponse_results = new List<MergeFacesResponse.MergeFaces_Result>();
			for (int i = 0; i < context.Length("MergeFaces.Results.Length"); i++) {
				MergeFacesResponse.MergeFaces_Result result = new MergeFacesResponse.MergeFaces_Result();
				result.Id = context.LongValue("MergeFaces.Results["+ i +"].Id");
				result.IdStr = context.StringValue("MergeFaces.Results["+ i +"].IdStr");
				result.Code = context.StringValue("MergeFaces.Results["+ i +"].Code");
				result.Message = context.StringValue("MergeFaces.Results["+ i +"].Message");

				mergeFacesResponse_results.Add(result);
			}
			mergeFacesResponse.Results = mergeFacesResponse_results;
        
			return mergeFacesResponse;
        }
    }
}
