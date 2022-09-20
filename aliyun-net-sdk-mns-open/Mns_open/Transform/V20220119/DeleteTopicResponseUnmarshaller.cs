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
using Aliyun.Acs.Mns_open.Model.V20220119;

namespace Aliyun.Acs.Mns_open.Transform.V20220119
{
    public class DeleteTopicResponseUnmarshaller
    {
        public static DeleteTopicResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteTopicResponse deleteTopicResponse = new DeleteTopicResponse();

			deleteTopicResponse.HttpResponse = _ctx.HttpResponse;
			deleteTopicResponse.RequestId = _ctx.StringValue("DeleteTopic.RequestId");
			deleteTopicResponse.Code = _ctx.LongValue("DeleteTopic.Code");
			deleteTopicResponse.Status = _ctx.StringValue("DeleteTopic.Status");
			deleteTopicResponse.Message = _ctx.StringValue("DeleteTopic.Message");
			deleteTopicResponse.Success = _ctx.BooleanValue("DeleteTopic.Success");
			deleteTopicResponse.Data = _ctx.StringValue("DeleteTopic.Data");
        
			return deleteTopicResponse;
        }
    }
}
