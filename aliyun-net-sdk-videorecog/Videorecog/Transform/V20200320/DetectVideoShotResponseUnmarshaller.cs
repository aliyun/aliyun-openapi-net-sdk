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
using Aliyun.Acs.videorecog.Model.V20200320;

namespace Aliyun.Acs.videorecog.Transform.V20200320
{
    public class DetectVideoShotResponseUnmarshaller
    {
        public static DetectVideoShotResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectVideoShotResponse detectVideoShotResponse = new DetectVideoShotResponse();

			detectVideoShotResponse.HttpResponse = _ctx.HttpResponse;
			detectVideoShotResponse.RequestId = _ctx.StringValue("DetectVideoShot.RequestId");

			DetectVideoShotResponse.DetectVideoShot_Data data = new DetectVideoShotResponse.DetectVideoShot_Data();

			List<string> data_shotFrameIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectVideoShot.Data.ShotFrameIds.Length"); i++) {
				data_shotFrameIds.Add(_ctx.StringValue("DetectVideoShot.Data.ShotFrameIds["+ i +"]"));
			}
			data.ShotFrameIds = data_shotFrameIds;
			detectVideoShotResponse.Data = data;
        
			return detectVideoShotResponse;
        }
    }
}
