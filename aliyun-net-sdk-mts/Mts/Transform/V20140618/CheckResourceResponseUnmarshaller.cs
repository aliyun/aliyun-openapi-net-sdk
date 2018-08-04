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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class CheckResourceResponseUnmarshaller
    {
        public static CheckResourceResponse Unmarshall(UnmarshallerContext context)
        {
			CheckResourceResponse checkResourceResponse = new CheckResourceResponse();

			checkResourceResponse.HttpResponse = context.HttpResponse;
			checkResourceResponse.Interrupt = context.BooleanValue("CheckResource.Interrupt");
			checkResourceResponse.Invoker = context.StringValue("CheckResource.Invoker");
			checkResourceResponse.Pk = context.StringValue("CheckResource.Pk");
			checkResourceResponse.Bid = context.StringValue("CheckResource.Bid");
			checkResourceResponse.Hid = context.LongValue("CheckResource.Hid");
			checkResourceResponse.Country = context.StringValue("CheckResource.Country");
			checkResourceResponse.TaskIdentifier = context.StringValue("CheckResource.TaskIdentifier");
			checkResourceResponse.TaskExtraData = context.StringValue("CheckResource.TaskExtraData");
			checkResourceResponse.GmtWakeup = context.StringValue("CheckResource.GmtWakeup");
			checkResourceResponse.Success = context.BooleanValue("CheckResource.Success");
			checkResourceResponse.Message = context.StringValue("CheckResource.Message");
			checkResourceResponse.Level = context.LongValue("CheckResource.Level");
			checkResourceResponse.Url = context.StringValue("CheckResource.Url");
			checkResourceResponse.Prompt = context.StringValue("CheckResource.Prompt");
        
			return checkResourceResponse;
        }
    }
}