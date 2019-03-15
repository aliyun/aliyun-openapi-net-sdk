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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class DeleteMcuJobResponseUnmarshaller
    {
        public static DeleteMcuJobResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteMcuJobResponse deleteMcuJobResponse = new DeleteMcuJobResponse();

			deleteMcuJobResponse.HttpResponse = context.HttpResponse;
			deleteMcuJobResponse.RequestId = context.StringValue("DeleteMcuJob.RequestId");

			List<string> deleteMcuJobResponse_nonExistJobIds = new List<string>();
			for (int i = 0; i < context.Length("DeleteMcuJob.NonExistJobIds.Length"); i++) {
				deleteMcuJobResponse_nonExistJobIds.Add(context.StringValue("DeleteMcuJob.NonExistJobIds["+ i +"]"));
			}
			deleteMcuJobResponse.NonExistJobIds = deleteMcuJobResponse_nonExistJobIds;

			List<string> deleteMcuJobResponse_deletedJobIds = new List<string>();
			for (int i = 0; i < context.Length("DeleteMcuJob.DeletedJobIds.Length"); i++) {
				deleteMcuJobResponse_deletedJobIds.Add(context.StringValue("DeleteMcuJob.DeletedJobIds["+ i +"]"));
			}
			deleteMcuJobResponse.DeletedJobIds = deleteMcuJobResponse_deletedJobIds;
        
			return deleteMcuJobResponse;
        }
    }
}
