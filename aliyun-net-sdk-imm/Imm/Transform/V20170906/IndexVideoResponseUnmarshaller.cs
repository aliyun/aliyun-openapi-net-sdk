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
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class IndexVideoResponseUnmarshaller
    {
        public static IndexVideoResponse Unmarshall(UnmarshallerContext context)
        {
			IndexVideoResponse indexVideoResponse = new IndexVideoResponse();

			indexVideoResponse.HttpResponse = context.HttpResponse;
			indexVideoResponse.RequestId = context.StringValue("IndexVideo.RequestId");
			indexVideoResponse.SetId = context.StringValue("IndexVideo.SetId");
			indexVideoResponse.VideoUri = context.StringValue("IndexVideo.VideoUri");
			indexVideoResponse.RemarksA = context.StringValue("IndexVideo.RemarksA");
			indexVideoResponse.RemarksB = context.StringValue("IndexVideo.RemarksB");
			indexVideoResponse.CreateTime = context.StringValue("IndexVideo.CreateTime");
			indexVideoResponse.ModifyTime = context.StringValue("IndexVideo.ModifyTime");
			indexVideoResponse.Interval = context.FloatValue("IndexVideo.Interval");
			indexVideoResponse.GrabType = context.StringValue("IndexVideo.GrabType");
			indexVideoResponse.StartTime = context.StringValue("IndexVideo.StartTime");
			indexVideoResponse.EndTime = context.StringValue("IndexVideo.EndTime");
			indexVideoResponse.SaveType = context.BooleanValue("IndexVideo.SaveType");
			indexVideoResponse.TgtUri = context.StringValue("IndexVideo.TgtUri");
        
			return indexVideoResponse;
        }
    }
}