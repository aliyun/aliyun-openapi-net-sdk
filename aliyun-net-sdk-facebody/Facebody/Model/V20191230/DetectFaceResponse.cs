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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.facebody.Model.V20191230
{
	public class DetectFaceResponse : AcsResponse
	{

		private string requestId;

		private DetectFace_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public DetectFace_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DetectFace_Data
		{

			private int? faceCount;

			private int? landmarkCount;

			private List<string> faceRectangles;

			private List<string> faceProbabilityList;

			private List<string> poseList;

			private List<string> landmarks;

			private List<string> pupils;

			public int? FaceCount
			{
				get
				{
					return faceCount;
				}
				set	
				{
					faceCount = value;
				}
			}

			public int? LandmarkCount
			{
				get
				{
					return landmarkCount;
				}
				set	
				{
					landmarkCount = value;
				}
			}

			public List<string> FaceRectangles
			{
				get
				{
					return faceRectangles;
				}
				set	
				{
					faceRectangles = value;
				}
			}

			public List<string> FaceProbabilityList
			{
				get
				{
					return faceProbabilityList;
				}
				set	
				{
					faceProbabilityList = value;
				}
			}

			public List<string> PoseList
			{
				get
				{
					return poseList;
				}
				set	
				{
					poseList = value;
				}
			}

			public List<string> Landmarks
			{
				get
				{
					return landmarks;
				}
				set	
				{
					landmarks = value;
				}
			}

			public List<string> Pupils
			{
				get
				{
					return pupils;
				}
				set	
				{
					pupils = value;
				}
			}
		}
	}
}
