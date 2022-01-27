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

			private int? landmarkCount;

			private int? faceCount;

			private List<string> faceProbabilityList;

			private List<string> faceRectangles;

			private List<string> landmarks;

			private List<string> poseList;

			private List<string> pupils;

			private DetectFace_Qualities qualities;

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

			public DetectFace_Qualities Qualities
			{
				get
				{
					return qualities;
				}
				set	
				{
					qualities = value;
				}
			}

			public class DetectFace_Qualities
			{

				private List<string> noiseList;

				private List<string> scoreList;

				private List<string> blurList;

				private List<string> maskList;

				private List<string> glassList;

				private List<string> fnfList;

				private List<string> poseList1;

				private List<string> illuList;

				public List<string> NoiseList
				{
					get
					{
						return noiseList;
					}
					set	
					{
						noiseList = value;
					}
				}

				public List<string> ScoreList
				{
					get
					{
						return scoreList;
					}
					set	
					{
						scoreList = value;
					}
				}

				public List<string> BlurList
				{
					get
					{
						return blurList;
					}
					set	
					{
						blurList = value;
					}
				}

				public List<string> MaskList
				{
					get
					{
						return maskList;
					}
					set	
					{
						maskList = value;
					}
				}

				public List<string> GlassList
				{
					get
					{
						return glassList;
					}
					set	
					{
						glassList = value;
					}
				}

				public List<string> FnfList
				{
					get
					{
						return fnfList;
					}
					set	
					{
						fnfList = value;
					}
				}

				public List<string> PoseList1
				{
					get
					{
						return poseList1;
					}
					set	
					{
						poseList1 = value;
					}
				}

				public List<string> IlluList
				{
					get
					{
						return illuList;
					}
					set	
					{
						illuList = value;
					}
				}
			}
		}
	}
}
