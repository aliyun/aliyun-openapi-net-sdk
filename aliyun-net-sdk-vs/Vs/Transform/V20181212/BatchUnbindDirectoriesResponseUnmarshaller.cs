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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class BatchUnbindDirectoriesResponseUnmarshaller
    {
        public static BatchUnbindDirectoriesResponse Unmarshall(UnmarshallerContext context)
        {
			BatchUnbindDirectoriesResponse batchUnbindDirectoriesResponse = new BatchUnbindDirectoriesResponse();

			batchUnbindDirectoriesResponse.HttpResponse = context.HttpResponse;
			batchUnbindDirectoriesResponse.RequestId = context.StringValue("BatchUnbindDirectories.RequestId");

			List<BatchUnbindDirectoriesResponse.BatchUnbindDirectories_Result> batchUnbindDirectoriesResponse_results = new List<BatchUnbindDirectoriesResponse.BatchUnbindDirectories_Result>();
			for (int i = 0; i < context.Length("BatchUnbindDirectories.Results.Length"); i++) {
				BatchUnbindDirectoriesResponse.BatchUnbindDirectories_Result result = new BatchUnbindDirectoriesResponse.BatchUnbindDirectories_Result();
				result.DirectoryId = context.StringValue("BatchUnbindDirectories.Results["+ i +"].DirectoryId");
				result.DeviceId = context.StringValue("BatchUnbindDirectories.Results["+ i +"].DeviceId");
				result.Error = context.StringValue("BatchUnbindDirectories.Results["+ i +"].Error");

				batchUnbindDirectoriesResponse_results.Add(result);
			}
			batchUnbindDirectoriesResponse.Results = batchUnbindDirectoriesResponse_results;
        
			return batchUnbindDirectoriesResponse;
        }
    }
}
