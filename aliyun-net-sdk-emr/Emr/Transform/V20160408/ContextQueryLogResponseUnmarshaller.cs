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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ContextQueryLogResponseUnmarshaller
    {
        public static ContextQueryLogResponse Unmarshall(UnmarshallerContext context)
        {
			ContextQueryLogResponse contextQueryLogResponse = new ContextQueryLogResponse();

			contextQueryLogResponse.HttpResponse = context.HttpResponse;
			contextQueryLogResponse.RequestId = context.StringValue("ContextQueryLog.RequestId");
			contextQueryLogResponse.PackId = context.StringValue("ContextQueryLog.PackId");
			contextQueryLogResponse.PackMeta = context.StringValue("ContextQueryLog.PackMeta");
			contextQueryLogResponse.Time = context.StringValue("ContextQueryLog.Time");

			List<ContextQueryLogResponse.ContextQueryLog_Item> contextQueryLogResponse_logs = new List<ContextQueryLogResponse.ContextQueryLog_Item>();
			for (int i = 0; i < context.Length("ContextQueryLog.Logs.Length"); i++) {
				ContextQueryLogResponse.ContextQueryLog_Item item = new ContextQueryLogResponse.ContextQueryLog_Item();
				item.Index = context.IntegerValue("ContextQueryLog.Logs["+ i +"].Index");
				item.Content = context.StringValue("ContextQueryLog.Logs["+ i +"].Content");

				contextQueryLogResponse_logs.Add(item);
			}
			contextQueryLogResponse.Logs = contextQueryLogResponse_logs;
        
			return contextQueryLogResponse;
        }
    }
}
