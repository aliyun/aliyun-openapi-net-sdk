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
using Aliyun.Acs.imageprocess.Model.V20200320;

namespace Aliyun.Acs.imageprocess.Transform.V20200320
{
    public class DetectKneeKeypointXRayResponseUnmarshaller
    {
        public static DetectKneeKeypointXRayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectKneeKeypointXRayResponse detectKneeKeypointXRayResponse = new DetectKneeKeypointXRayResponse();

			detectKneeKeypointXRayResponse.HttpResponse = _ctx.HttpResponse;
			detectKneeKeypointXRayResponse.RequestId = _ctx.StringValue("DetectKneeKeypointXRay.RequestId");

			DetectKneeKeypointXRayResponse.DetectKneeKeypointXRay_Data data = new DetectKneeKeypointXRayResponse.DetectKneeKeypointXRay_Data();
			data.ImageUrl = _ctx.StringValue("DetectKneeKeypointXRay.Data.ImageUrl");
			data.OrgId = _ctx.StringValue("DetectKneeKeypointXRay.Data.OrgId");
			data.OrgName = _ctx.StringValue("DetectKneeKeypointXRay.Data.OrgName");

			List<DetectKneeKeypointXRayResponse.DetectKneeKeypointXRay_Data.DetectKneeKeypointXRay_KeyPointsItem> data_keyPoints = new List<DetectKneeKeypointXRayResponse.DetectKneeKeypointXRay_Data.DetectKneeKeypointXRay_KeyPointsItem>();
			for (int i = 0; i < _ctx.Length("DetectKneeKeypointXRay.Data.KeyPoints.Length"); i++) {
				DetectKneeKeypointXRayResponse.DetectKneeKeypointXRay_Data.DetectKneeKeypointXRay_KeyPointsItem keyPointsItem = new DetectKneeKeypointXRayResponse.DetectKneeKeypointXRay_Data.DetectKneeKeypointXRay_KeyPointsItem();
				keyPointsItem._Value = _ctx.FloatValue("DetectKneeKeypointXRay.Data.KeyPoints["+ i +"].Value");

				List<string> keyPointsItem_coordinates = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectKneeKeypointXRay.Data.KeyPoints["+ i +"].Coordinates.Length"); j++) {
					keyPointsItem_coordinates.Add(_ctx.StringValue("DetectKneeKeypointXRay.Data.KeyPoints["+ i +"].Coordinates["+ j +"]"));
				}
				keyPointsItem.Coordinates = keyPointsItem_coordinates;

				DetectKneeKeypointXRayResponse.DetectKneeKeypointXRay_Data.DetectKneeKeypointXRay_KeyPointsItem.DetectKneeKeypointXRay_Tag tag = new DetectKneeKeypointXRayResponse.DetectKneeKeypointXRay_Data.DetectKneeKeypointXRay_KeyPointsItem.DetectKneeKeypointXRay_Tag();
				tag.Direction = _ctx.StringValue("DetectKneeKeypointXRay.Data.KeyPoints["+ i +"].Tag.Direction");
				tag.Label = _ctx.StringValue("DetectKneeKeypointXRay.Data.KeyPoints["+ i +"].Tag.Label");
				keyPointsItem.Tag = tag;

				data_keyPoints.Add(keyPointsItem);
			}
			data.KeyPoints = data_keyPoints;
			detectKneeKeypointXRayResponse.Data = data;
        
			return detectKneeKeypointXRayResponse;
        }
    }
}
