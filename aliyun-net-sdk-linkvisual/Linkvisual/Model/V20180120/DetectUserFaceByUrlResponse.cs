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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
	public class DetectUserFaceByUrlResponse : AcsResponse
	{

		private string code;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private List<DetectUserFaceByUrl_DataItem> data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<DetectUserFaceByUrl_DataItem> Data
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

		public class DetectUserFaceByUrl_DataItem
		{

			private float? blurScore;

			private int? gender;

			private float? occlusionScore;

			private bool? goodForLibrary;

			private bool? goodForRecognition;

			private int? age;

			private float? faceProbability;

			private float? poseScore;

			private List<string> faceRects;

			private List<string> landmarks;

			public float? BlurScore
			{
				get
				{
					return blurScore;
				}
				set	
				{
					blurScore = value;
				}
			}

			public int? Gender
			{
				get
				{
					return gender;
				}
				set	
				{
					gender = value;
				}
			}

			public float? OcclusionScore
			{
				get
				{
					return occlusionScore;
				}
				set	
				{
					occlusionScore = value;
				}
			}

			public bool? GoodForLibrary
			{
				get
				{
					return goodForLibrary;
				}
				set	
				{
					goodForLibrary = value;
				}
			}

			public bool? GoodForRecognition
			{
				get
				{
					return goodForRecognition;
				}
				set	
				{
					goodForRecognition = value;
				}
			}

			public int? Age
			{
				get
				{
					return age;
				}
				set	
				{
					age = value;
				}
			}

			public float? FaceProbability
			{
				get
				{
					return faceProbability;
				}
				set	
				{
					faceProbability = value;
				}
			}

			public float? PoseScore
			{
				get
				{
					return poseScore;
				}
				set	
				{
					poseScore = value;
				}
			}

			public List<string> FaceRects
			{
				get
				{
					return faceRects;
				}
				set	
				{
					faceRects = value;
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
		}
	}
}
