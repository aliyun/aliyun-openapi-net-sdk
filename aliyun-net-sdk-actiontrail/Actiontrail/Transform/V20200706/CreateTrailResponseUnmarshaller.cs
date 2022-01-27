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
using Aliyun.Acs.Actiontrail.Model.V20200706;

namespace Aliyun.Acs.Actiontrail.Transform.V20200706
{
    public class CreateTrailResponseUnmarshaller
    {
        public static CreateTrailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTrailResponse createTrailResponse = new CreateTrailResponse();

			createTrailResponse.HttpResponse = _ctx.HttpResponse;
			createTrailResponse.SlsProjectArn = _ctx.StringValue("CreateTrail.SlsProjectArn");
			createTrailResponse.EventRW = _ctx.StringValue("CreateTrail.EventRW");
			createTrailResponse.RequestId = _ctx.StringValue("CreateTrail.RequestId");
			createTrailResponse.HomeRegion = _ctx.StringValue("CreateTrail.HomeRegion");
			createTrailResponse.OssKeyPrefix = _ctx.StringValue("CreateTrail.OssKeyPrefix");
			createTrailResponse.OssBucketName = _ctx.StringValue("CreateTrail.OssBucketName");
			createTrailResponse.SlsWriteRoleArn = _ctx.StringValue("CreateTrail.SlsWriteRoleArn");
			createTrailResponse.OssWriteRoleArn = _ctx.StringValue("CreateTrail.OssWriteRoleArn");
			createTrailResponse.TrailRegion = _ctx.StringValue("CreateTrail.TrailRegion");
			createTrailResponse.Name = _ctx.StringValue("CreateTrail.Name");
        
			return createTrailResponse;
        }
    }
}
