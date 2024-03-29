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
using Aliyun.Acs.videoseg.Model.V20200320;

namespace Aliyun.Acs.videoseg.Transform.V20200320
{
    public class SegmentHalfBodyResponseUnmarshaller
    {
        public static SegmentHalfBodyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SegmentHalfBodyResponse segmentHalfBodyResponse = new SegmentHalfBodyResponse();

			segmentHalfBodyResponse.HttpResponse = _ctx.HttpResponse;
			segmentHalfBodyResponse.RequestId = _ctx.StringValue("SegmentHalfBody.RequestId");
			segmentHalfBodyResponse.Code = _ctx.StringValue("SegmentHalfBody.Code");
			segmentHalfBodyResponse.Message = _ctx.StringValue("SegmentHalfBody.Message");

			SegmentHalfBodyResponse.SegmentHalfBody_Data data = new SegmentHalfBodyResponse.SegmentHalfBody_Data();
			data.VideoUrl = _ctx.StringValue("SegmentHalfBody.Data.VideoUrl");
			segmentHalfBodyResponse.Data = data;
        
			return segmentHalfBodyResponse;
        }
    }
}
