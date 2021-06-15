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
    public class UpdateTrailResponseUnmarshaller
    {
        public static UpdateTrailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateTrailResponse updateTrailResponse = new UpdateTrailResponse();

			updateTrailResponse.HttpResponse = _ctx.HttpResponse;
			updateTrailResponse.SlsProjectArn = _ctx.StringValue("UpdateTrail.SlsProjectArn");
			updateTrailResponse.EventRW = _ctx.StringValue("UpdateTrail.EventRW");
			updateTrailResponse.RequestId = _ctx.StringValue("UpdateTrail.RequestId");
			updateTrailResponse.HomeRegion = _ctx.StringValue("UpdateTrail.HomeRegion");
			updateTrailResponse.OssKeyPrefix = _ctx.StringValue("UpdateTrail.OssKeyPrefix");
			updateTrailResponse.OssBucketName = _ctx.StringValue("UpdateTrail.OssBucketName");
			updateTrailResponse.SlsWriteRoleArn = _ctx.StringValue("UpdateTrail.SlsWriteRoleArn");
			updateTrailResponse.OssWriteRoleArn = _ctx.StringValue("UpdateTrail.OssWriteRoleArn");
			updateTrailResponse.TrailRegion = _ctx.StringValue("UpdateTrail.TrailRegion");
			updateTrailResponse.Name = _ctx.StringValue("UpdateTrail.Name");
        
			return updateTrailResponse;
        }
    }
}
