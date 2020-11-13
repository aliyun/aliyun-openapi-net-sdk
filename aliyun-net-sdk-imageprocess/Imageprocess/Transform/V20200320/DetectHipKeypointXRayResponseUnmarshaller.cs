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
    public class DetectHipKeypointXRayResponseUnmarshaller
    {
        public static DetectHipKeypointXRayResponse Unmarshall(UnmarshallerContext context)
        {
			DetectHipKeypointXRayResponse detectHipKeypointXRayResponse = new DetectHipKeypointXRayResponse();

			detectHipKeypointXRayResponse.HttpResponse = context.HttpResponse;
			detectHipKeypointXRayResponse.RequestId = context.StringValue("DetectHipKeypointXRay.RequestId");

			DetectHipKeypointXRayResponse.DetectHipKeypointXRay_Data data = new DetectHipKeypointXRayResponse.DetectHipKeypointXRay_Data();
			data.ImageUrl = context.StringValue("DetectHipKeypointXRay.Data.ImageUrl");
			data.OrgId = context.StringValue("DetectHipKeypointXRay.Data.OrgId");
			data.OrgName = context.StringValue("DetectHipKeypointXRay.Data.OrgName");

			List<DetectHipKeypointXRayResponse.DetectHipKeypointXRay_Data.DetectHipKeypointXRay_KeyPointsItem> data_keyPoints = new List<DetectHipKeypointXRayResponse.DetectHipKeypointXRay_Data.DetectHipKeypointXRay_KeyPointsItem>();
			for (int i = 0; i < context.Length("DetectHipKeypointXRay.Data.KeyPoints.Length"); i++) {
				DetectHipKeypointXRayResponse.DetectHipKeypointXRay_Data.DetectHipKeypointXRay_KeyPointsItem keyPointsItem = new DetectHipKeypointXRayResponse.DetectHipKeypointXRay_Data.DetectHipKeypointXRay_KeyPointsItem();
				keyPointsItem._Value = context.FloatValue("DetectHipKeypointXRay.Data.KeyPoints["+ i +"].Value");

				List<string> keyPointsItem_coordinates = new List<string>();
				for (int j = 0; j < context.Length("DetectHipKeypointXRay.Data.KeyPoints["+ i +"].Coordinates.Length"); j++) {
					keyPointsItem_coordinates.Add(context.StringValue("DetectHipKeypointXRay.Data.KeyPoints["+ i +"].Coordinates["+ j +"]"));
				}
				keyPointsItem.Coordinates = keyPointsItem_coordinates;

				DetectHipKeypointXRayResponse.DetectHipKeypointXRay_Data.DetectHipKeypointXRay_KeyPointsItem.DetectHipKeypointXRay_Tag tag = new DetectHipKeypointXRayResponse.DetectHipKeypointXRay_Data.DetectHipKeypointXRay_KeyPointsItem.DetectHipKeypointXRay_Tag();
				tag.Direction = context.StringValue("DetectHipKeypointXRay.Data.KeyPoints["+ i +"].Tag.Direction");
				tag.Label = context.StringValue("DetectHipKeypointXRay.Data.KeyPoints["+ i +"].Tag.Label");
				keyPointsItem.Tag = tag;

				data_keyPoints.Add(keyPointsItem);
			}
			data.KeyPoints = data_keyPoints;
			detectHipKeypointXRayResponse.Data = data;
        
			return detectHipKeypointXRayResponse;
        }
    }
}
