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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class IndexVideoResponseUnmarshaller
    {
        public static IndexVideoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			IndexVideoResponse indexVideoResponse = new IndexVideoResponse();

			indexVideoResponse.HttpResponse = _ctx.HttpResponse;
			indexVideoResponse.ModifyTime = _ctx.StringValue("IndexVideo.ModifyTime");
			indexVideoResponse.RequestId = _ctx.StringValue("IndexVideo.RequestId");
			indexVideoResponse.EndTime = _ctx.StringValue("IndexVideo.EndTime");
			indexVideoResponse.SaveType = _ctx.BooleanValue("IndexVideo.SaveType");
			indexVideoResponse.ExternalId = _ctx.StringValue("IndexVideo.ExternalId");
			indexVideoResponse.CreateTime = _ctx.StringValue("IndexVideo.CreateTime");
			indexVideoResponse.StartTime = _ctx.StringValue("IndexVideo.StartTime");
			indexVideoResponse.VideoUri = _ctx.StringValue("IndexVideo.VideoUri");
			indexVideoResponse.GrabType = _ctx.StringValue("IndexVideo.GrabType");
			indexVideoResponse.RemarksA = _ctx.StringValue("IndexVideo.RemarksA");
			indexVideoResponse.RemarksB = _ctx.StringValue("IndexVideo.RemarksB");
			indexVideoResponse.RemarksC = _ctx.StringValue("IndexVideo.RemarksC");
			indexVideoResponse.TgtUri = _ctx.StringValue("IndexVideo.TgtUri");
			indexVideoResponse.RemarksD = _ctx.StringValue("IndexVideo.RemarksD");
			indexVideoResponse.SetId = _ctx.StringValue("IndexVideo.SetId");
			indexVideoResponse.Interval = _ctx.FloatValue("IndexVideo.Interval");
        
			return indexVideoResponse;
        }
    }
}
