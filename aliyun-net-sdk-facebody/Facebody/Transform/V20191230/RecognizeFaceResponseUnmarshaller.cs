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
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class RecognizeFaceResponseUnmarshaller
    {
        public static RecognizeFaceResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeFaceResponse recognizeFaceResponse = new RecognizeFaceResponse();

			recognizeFaceResponse.HttpResponse = context.HttpResponse;
			recognizeFaceResponse.RequestId = context.StringValue("RecognizeFace.RequestId");

			RecognizeFaceResponse.RecognizeFace_Data data = new RecognizeFaceResponse.RecognizeFace_Data();
			data.FaceCount = context.IntegerValue("RecognizeFace.Data.FaceCount");
			data.LandmarkCount = context.IntegerValue("RecognizeFace.Data.LandmarkCount");
			data.DenseFeatureLength = context.IntegerValue("RecognizeFace.Data.DenseFeatureLength");

			List<string> data_faceRectangles = new List<string>();
			for (int i = 0; i < context.Length("RecognizeFace.Data.FaceRectangles.Length"); i++) {
				data_faceRectangles.Add(context.StringValue("RecognizeFace.Data.FaceRectangles["+ i +"]"));
			}
			data.FaceRectangles = data_faceRectangles;

			List<string> data_faceProbabilityList = new List<string>();
			for (int i = 0; i < context.Length("RecognizeFace.Data.FaceProbabilityList.Length"); i++) {
				data_faceProbabilityList.Add(context.StringValue("RecognizeFace.Data.FaceProbabilityList["+ i +"]"));
			}
			data.FaceProbabilityList = data_faceProbabilityList;

			List<string> data_poseList = new List<string>();
			for (int i = 0; i < context.Length("RecognizeFace.Data.PoseList.Length"); i++) {
				data_poseList.Add(context.StringValue("RecognizeFace.Data.PoseList["+ i +"]"));
			}
			data.PoseList = data_poseList;

			List<string> data_landmarks = new List<string>();
			for (int i = 0; i < context.Length("RecognizeFace.Data.Landmarks.Length"); i++) {
				data_landmarks.Add(context.StringValue("RecognizeFace.Data.Landmarks["+ i +"]"));
			}
			data.Landmarks = data_landmarks;

			List<string> data_pupils = new List<string>();
			for (int i = 0; i < context.Length("RecognizeFace.Data.Pupils.Length"); i++) {
				data_pupils.Add(context.StringValue("RecognizeFace.Data.Pupils["+ i +"]"));
			}
			data.Pupils = data_pupils;

			List<string> data_genderList = new List<string>();
			for (int i = 0; i < context.Length("RecognizeFace.Data.GenderList.Length"); i++) {
				data_genderList.Add(context.StringValue("RecognizeFace.Data.GenderList["+ i +"]"));
			}
			data.GenderList = data_genderList;

			List<string> data_ageList = new List<string>();
			for (int i = 0; i < context.Length("RecognizeFace.Data.AgeList.Length"); i++) {
				data_ageList.Add(context.StringValue("RecognizeFace.Data.AgeList["+ i +"]"));
			}
			data.AgeList = data_ageList;

			List<string> data_expressions = new List<string>();
			for (int i = 0; i < context.Length("RecognizeFace.Data.Expressions.Length"); i++) {
				data_expressions.Add(context.StringValue("RecognizeFace.Data.Expressions["+ i +"]"));
			}
			data.Expressions = data_expressions;

			List<string> data_glasses = new List<string>();
			for (int i = 0; i < context.Length("RecognizeFace.Data.Glasses.Length"); i++) {
				data_glasses.Add(context.StringValue("RecognizeFace.Data.Glasses["+ i +"]"));
			}
			data.Glasses = data_glasses;

			List<string> data_denseFeatures = new List<string>();
			for (int i = 0; i < context.Length("RecognizeFace.Data.DenseFeatures.Length"); i++) {
				data_denseFeatures.Add(context.StringValue("RecognizeFace.Data.DenseFeatures["+ i +"]"));
			}
			data.DenseFeatures = data_denseFeatures;
			recognizeFaceResponse.Data = data;
        
			return recognizeFaceResponse;
        }
    }
}
