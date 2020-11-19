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
using Aliyun.Acs.imageseg.Model.V20191230;

namespace Aliyun.Acs.imageseg.Transform.V20191230
{
    public class SegmentLogoResponseUnmarshaller
    {
        public static SegmentLogoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SegmentLogoResponse segmentLogoResponse = new SegmentLogoResponse();

			segmentLogoResponse.HttpResponse = _ctx.HttpResponse;
			segmentLogoResponse.RequestId = _ctx.StringValue("SegmentLogo.RequestId");

			SegmentLogoResponse.SegmentLogo_Data data = new SegmentLogoResponse.SegmentLogo_Data();
			data.ImageURL = _ctx.StringValue("SegmentLogo.Data.ImageURL");
			segmentLogoResponse.Data = data;
        
			return segmentLogoResponse;
        }
    }
}
