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
    public class FaceCompareResponseUnmarshaller
    {
        public static FaceCompareResponse Unmarshall(UnmarshallerContext context)
        {
			FaceCompareResponse faceCompareResponse = new FaceCompareResponse();

			faceCompareResponse.HttpResponse = context.HttpResponse;
			faceCompareResponse.RequestId = context.StringValue("FaceCompare.RequestId");

			List<FaceCompareResponse.FaceCompare_CompareResultItem> faceCompareResponse_compareResult = new List<FaceCompareResponse.FaceCompare_CompareResultItem>();
			for (int i = 0; i < context.Length("FaceCompare.CompareResult.Length"); i++) {
				FaceCompareResponse.FaceCompare_CompareResultItem compareResultItem = new FaceCompareResponse.FaceCompare_CompareResultItem();
				compareResultItem.Similarity = context.FloatValue("FaceCompare.CompareResult["+ i +"].Similarity");

				FaceCompareResponse.FaceCompare_CompareResultItem.FaceCompare_FaceA faceA = new FaceCompareResponse.FaceCompare_CompareResultItem.FaceCompare_FaceA();
				faceA.ImageUrl = context.StringValue("FaceCompare.CompareResult["+ i +"].FaceA.ImageUrl");

				List<string> faceA_axis = new List<string>();
				for (int j = 0; j < context.Length("FaceCompare.CompareResult["+ i +"].FaceA.Axis.Length"); j++) {
					faceA_axis.Add(context.StringValue("FaceCompare.CompareResult["+ i +"].FaceA.Axis["+ j +"]"));
				}
				faceA.Axis = faceA_axis;
				compareResultItem.FaceA = faceA;

				FaceCompareResponse.FaceCompare_CompareResultItem.FaceCompare_FaceB faceB = new FaceCompareResponse.FaceCompare_CompareResultItem.FaceCompare_FaceB();
				faceB.ImageUrl = context.StringValue("FaceCompare.CompareResult["+ i +"].FaceB.ImageUrl");

				List<string> faceB_axis1 = new List<string>();
				for (int j = 0; j < context.Length("FaceCompare.CompareResult["+ i +"].FaceB.Axis.Length"); j++) {
					faceB_axis1.Add(context.StringValue("FaceCompare.CompareResult["+ i +"].FaceB.Axis["+ j +"]"));
				}
				faceB.Axis1 = faceB_axis1;
				compareResultItem.FaceB = faceB;

				faceCompareResponse_compareResult.Add(compareResultItem);
			}
			faceCompareResponse.CompareResult = faceCompareResponse_compareResult;
        
			return faceCompareResponse;
        }
    }
}