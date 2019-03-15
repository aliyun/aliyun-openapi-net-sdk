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
    public class LogicalDeleteResourceResponseUnmarshaller
    {
        public static LogicalDeleteResourceResponse Unmarshall(UnmarshallerContext context)
        {
			LogicalDeleteResourceResponse logicalDeleteResourceResponse = new LogicalDeleteResourceResponse();

			logicalDeleteResourceResponse.HttpResponse = context.HttpResponse;
			logicalDeleteResourceResponse.Interrupt = context.BooleanValue("LogicalDeleteResource.Interrupt");
			logicalDeleteResourceResponse.Invoker = context.StringValue("LogicalDeleteResource.Invoker");
			logicalDeleteResourceResponse.Pk = context.StringValue("LogicalDeleteResource.Pk");
			logicalDeleteResourceResponse.Bid = context.StringValue("LogicalDeleteResource.Bid");
			logicalDeleteResourceResponse.Hid = context.LongValue("LogicalDeleteResource.Hid");
			logicalDeleteResourceResponse.Country = context.StringValue("LogicalDeleteResource.Country");
			logicalDeleteResourceResponse.TaskIdentifier = context.StringValue("LogicalDeleteResource.TaskIdentifier");
			logicalDeleteResourceResponse.TaskExtraData = context.StringValue("LogicalDeleteResource.TaskExtraData");
			logicalDeleteResourceResponse.GmtWakeup = context.StringValue("LogicalDeleteResource.GmtWakeup");
			logicalDeleteResourceResponse.Success = context.BooleanValue("LogicalDeleteResource.Success");
			logicalDeleteResourceResponse.Message = context.StringValue("LogicalDeleteResource.Message");
        
			return logicalDeleteResourceResponse;
        }
    }
}
