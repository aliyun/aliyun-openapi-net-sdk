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
    public class BatchBindDirectoriesResponseUnmarshaller
    {
        public static BatchBindDirectoriesResponse Unmarshall(UnmarshallerContext context)
        {
			BatchBindDirectoriesResponse batchBindDirectoriesResponse = new BatchBindDirectoriesResponse();

			batchBindDirectoriesResponse.HttpResponse = context.HttpResponse;
			batchBindDirectoriesResponse.RequestId = context.StringValue("BatchBindDirectories.RequestId");

			List<BatchBindDirectoriesResponse.BatchBindDirectories_Result> batchBindDirectoriesResponse_results = new List<BatchBindDirectoriesResponse.BatchBindDirectories_Result>();
			for (int i = 0; i < context.Length("BatchBindDirectories.Results.Length"); i++) {
				BatchBindDirectoriesResponse.BatchBindDirectories_Result result = new BatchBindDirectoriesResponse.BatchBindDirectories_Result();
				result.DirectoryId = context.StringValue("BatchBindDirectories.Results["+ i +"].DirectoryId");
				result.DeviceId = context.StringValue("BatchBindDirectories.Results["+ i +"].DeviceId");
				result.Error = context.StringValue("BatchBindDirectories.Results["+ i +"].Error");

				batchBindDirectoriesResponse_results.Add(result);
			}
			batchBindDirectoriesResponse.Results = batchBindDirectoriesResponse_results;
        
			return batchBindDirectoriesResponse;
        }
    }
}
