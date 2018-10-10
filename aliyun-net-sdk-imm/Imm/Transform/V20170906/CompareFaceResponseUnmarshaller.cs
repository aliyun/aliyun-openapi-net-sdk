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
    public class CompareFaceResponseUnmarshaller
    {
        public static CompareFaceResponse Unmarshall(UnmarshallerContext context)
        {
			CompareFaceResponse compareFaceResponse = new CompareFaceResponse();

			compareFaceResponse.HttpResponse = context.HttpResponse;
			compareFaceResponse.RequestId = context.StringValue("CompareFace.RequestId");

			List<CompareFaceResponse.CompareFace_CompareResultItem> compareFaceResponse_compareResult = new List<CompareFaceResponse.CompareFace_CompareResultItem>();
			for (int i = 0; i < context.Length("CompareFace.CompareResult.Length"); i++) {
				CompareFaceResponse.CompareFace_CompareResultItem compareResultItem = new CompareFaceResponse.CompareFace_CompareResultItem();
				compareResultItem.Similarity = context.FloatValue("CompareFace.CompareResult["+ i +"].Similarity");

				CompareFaceResponse.CompareFace_CompareResultItem.CompareFace_FaceA faceA = new CompareFaceResponse.CompareFace_CompareResultItem.CompareFace_FaceA();
				faceA.ImageUri = context.StringValue("CompareFace.CompareResult["+ i +"].FaceA.ImageUri");

				List<string> faceA_axis = new List<string>();
				for (int j = 0; j < context.Length("CompareFace.CompareResult["+ i +"].FaceA.Axis.Length"); j++) {
					faceA_axis.Add(context.StringValue("CompareFace.CompareResult["+ i +"].FaceA.Axis["+ j +"]"));
				}
				faceA.Axis = faceA_axis;
				compareResultItem.FaceA = faceA;

				CompareFaceResponse.CompareFace_CompareResultItem.CompareFace_FaceB faceB = new CompareFaceResponse.CompareFace_CompareResultItem.CompareFace_FaceB();
				faceB.ImageUri = context.StringValue("CompareFace.CompareResult["+ i +"].FaceB.ImageUri");

				List<string> faceB_axis1 = new List<string>();
				for (int j = 0; j < context.Length("CompareFace.CompareResult["+ i +"].FaceB.Axis.Length"); j++) {
					faceB_axis1.Add(context.StringValue("CompareFace.CompareResult["+ i +"].FaceB.Axis["+ j +"]"));
				}
				faceB.Axis1 = faceB_axis1;
				compareResultItem.FaceB = faceB;

				compareFaceResponse_compareResult.Add(compareResultItem);
			}
			compareFaceResponse.CompareResult = compareFaceResponse_compareResult;
        
			return compareFaceResponse;
        }
    }
}