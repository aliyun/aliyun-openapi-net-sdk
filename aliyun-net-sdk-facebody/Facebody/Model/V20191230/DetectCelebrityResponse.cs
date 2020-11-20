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
	public class DetectCelebrityResponse : AcsResponse
	{

		private string requestId;

		private DetectCelebrity_Data data;

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

		public DetectCelebrity_Data Data
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

		public class DetectCelebrity_Data
		{

			private int? width;

			private int? height;

			private List<DetectCelebrity_FaceRecognizeResult> faceRecognizeResults;

			public int? Width
			{
				get
				{
					return width;
				}
				set	
				{
					width = value;
				}
			}

			public int? Height
			{
				get
				{
					return height;
				}
				set	
				{
					height = value;
				}
			}

			public List<DetectCelebrity_FaceRecognizeResult> FaceRecognizeResults
			{
				get
				{
					return faceRecognizeResults;
				}
				set	
				{
					faceRecognizeResults = value;
				}
			}

			public class DetectCelebrity_FaceRecognizeResult
			{

				private string name;

				private List<string> faceBoxes;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public List<string> FaceBoxes
				{
					get
					{
						return faceBoxes;
					}
					set	
					{
						faceBoxes = value;
					}
				}
			}
		}
	}
}
