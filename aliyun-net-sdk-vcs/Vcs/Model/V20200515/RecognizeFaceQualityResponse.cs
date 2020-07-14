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

namespace Aliyun.Acs.Vcs.Model.V20200515
{
	public class RecognizeFaceQualityResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private RecognizeFaceQuality_Data data;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public RecognizeFaceQuality_Data Data
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

		public class RecognizeFaceQuality_Data
		{

			private string qualityScore;

			private string description;

			private RecognizeFaceQuality_Attributes attributes;

			public string QualityScore
			{
				get
				{
					return qualityScore;
				}
				set	
				{
					qualityScore = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public RecognizeFaceQuality_Attributes Attributes
			{
				get
				{
					return attributes;
				}
				set	
				{
					attributes = value;
				}
			}

			public class RecognizeFaceQuality_Attributes
			{

				private int? leftTopX;

				private int? leftTopY;

				private int? rightBottomX;

				private int? rightBottomY;

				private string targetImageStoragePath;

				private string faceStyle;

				private string faceQuality;

				private string faceScore;

				public int? LeftTopX
				{
					get
					{
						return leftTopX;
					}
					set	
					{
						leftTopX = value;
					}
				}

				public int? LeftTopY
				{
					get
					{
						return leftTopY;
					}
					set	
					{
						leftTopY = value;
					}
				}

				public int? RightBottomX
				{
					get
					{
						return rightBottomX;
					}
					set	
					{
						rightBottomX = value;
					}
				}

				public int? RightBottomY
				{
					get
					{
						return rightBottomY;
					}
					set	
					{
						rightBottomY = value;
					}
				}

				public string TargetImageStoragePath
				{
					get
					{
						return targetImageStoragePath;
					}
					set	
					{
						targetImageStoragePath = value;
					}
				}

				public string FaceStyle
				{
					get
					{
						return faceStyle;
					}
					set	
					{
						faceStyle = value;
					}
				}

				public string FaceQuality
				{
					get
					{
						return faceQuality;
					}
					set	
					{
						faceQuality = value;
					}
				}

				public string FaceScore
				{
					get
					{
						return faceScore;
					}
					set	
					{
						faceScore = value;
					}
				}
			}
		}
	}
}
