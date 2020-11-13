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
    public class DetectKneeXRayResponseUnmarshaller
    {
        public static DetectKneeXRayResponse Unmarshall(UnmarshallerContext context)
        {
			DetectKneeXRayResponse detectKneeXRayResponse = new DetectKneeXRayResponse();

			detectKneeXRayResponse.HttpResponse = context.HttpResponse;
			detectKneeXRayResponse.RequestId = context.StringValue("DetectKneeXRay.RequestId");

			DetectKneeXRayResponse.DetectKneeXRay_Data data = new DetectKneeXRayResponse.DetectKneeXRay_Data();

			List<DetectKneeXRayResponse.DetectKneeXRay_Data.DetectKneeXRay_KLDetectionsItem> data_kLDetections = new List<DetectKneeXRayResponse.DetectKneeXRay_Data.DetectKneeXRay_KLDetectionsItem>();
			for (int i = 0; i < context.Length("DetectKneeXRay.Data.KLDetections.Length"); i++) {
				DetectKneeXRayResponse.DetectKneeXRay_Data.DetectKneeXRay_KLDetectionsItem kLDetectionsItem = new DetectKneeXRayResponse.DetectKneeXRay_Data.DetectKneeXRay_KLDetectionsItem();

				List<string> kLDetectionsItem_detections = new List<string>();
				for (int j = 0; j < context.Length("DetectKneeXRay.Data.KLDetections["+ i +"].Detections.Length"); j++) {
					kLDetectionsItem_detections.Add(context.StringValue("DetectKneeXRay.Data.KLDetections["+ i +"].Detections["+ j +"]"));
				}
				kLDetectionsItem.Detections = kLDetectionsItem_detections;

				data_kLDetections.Add(kLDetectionsItem);
			}
			data.KLDetections = data_kLDetections;
			detectKneeXRayResponse.Data = data;
        
			return detectKneeXRayResponse;
        }
    }
}
