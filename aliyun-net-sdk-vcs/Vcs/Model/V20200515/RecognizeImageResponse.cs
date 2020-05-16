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
	public class RecognizeImageResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private RecognizeImage_Data data;

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

		public RecognizeImage_Data Data
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

		public class RecognizeImage_Data
		{

			private List<RecognizeImage_Body> bodyList;

			private List<RecognizeImage_Face> faceList;

			public List<RecognizeImage_Body> BodyList
			{
				get
				{
					return bodyList;
				}
				set	
				{
					bodyList = value;
				}
			}

			public List<RecognizeImage_Face> FaceList
			{
				get
				{
					return faceList;
				}
				set	
				{
					faceList = value;
				}
			}

			public class RecognizeImage_Body
			{

				private string feature;

				private string fileName;

				private string imageBaseSixFour;

				private string leftTopX;

				private string leftTopY;

				private string localFeature;

				private string respiratorColor;

				private string rightBottomX;

				private string rightBottomY;

				public string Feature
				{
					get
					{
						return feature;
					}
					set	
					{
						feature = value;
					}
				}

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
					}
				}

				public string ImageBaseSixFour
				{
					get
					{
						return imageBaseSixFour;
					}
					set	
					{
						imageBaseSixFour = value;
					}
				}

				public string LeftTopX
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

				public string LeftTopY
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

				public string LocalFeature
				{
					get
					{
						return localFeature;
					}
					set	
					{
						localFeature = value;
					}
				}

				public string RespiratorColor
				{
					get
					{
						return respiratorColor;
					}
					set	
					{
						respiratorColor = value;
					}
				}

				public string RightBottomX
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

				public string RightBottomY
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
			}

			public class RecognizeImage_Face
			{

				private string feature;

				private string fileName;

				private string imageBaseSixFour;

				private string leftTopX;

				private string leftTopY;

				private string localFeature;

				private string respiratorColor;

				private string rightBottomX;

				private string rightBottomY;

				public string Feature
				{
					get
					{
						return feature;
					}
					set	
					{
						feature = value;
					}
				}

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
					}
				}

				public string ImageBaseSixFour
				{
					get
					{
						return imageBaseSixFour;
					}
					set	
					{
						imageBaseSixFour = value;
					}
				}

				public string LeftTopX
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

				public string LeftTopY
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

				public string LocalFeature
				{
					get
					{
						return localFeature;
					}
					set	
					{
						localFeature = value;
					}
				}

				public string RespiratorColor
				{
					get
					{
						return respiratorColor;
					}
					set	
					{
						respiratorColor = value;
					}
				}

				public string RightBottomX
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

				public string RightBottomY
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
			}
		}
	}
}
