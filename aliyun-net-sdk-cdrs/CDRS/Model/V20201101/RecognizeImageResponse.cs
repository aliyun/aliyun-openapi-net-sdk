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

namespace Aliyun.Acs.CDRS.Model.V20201101
{
	public class RecognizeImageResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private string success;

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

		public string Success
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

			private List<RecognizeImage_BodyListItem> bodyList;

			private List<RecognizeImage_FaceListItem> faceList;

			public List<RecognizeImage_BodyListItem> BodyList
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

			public List<RecognizeImage_FaceListItem> FaceList
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

			public class RecognizeImage_BodyListItem
			{

				private int? leftTopX;

				private int? leftTopY;

				private int? rightBottomX;

				private int? rightBottomY;

				private string feature;

				private string targetImageContent;

				private string cropAlgorithmCode;

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

				public string TargetImageContent
				{
					get
					{
						return targetImageContent;
					}
					set	
					{
						targetImageContent = value;
					}
				}

				public string CropAlgorithmCode
				{
					get
					{
						return cropAlgorithmCode;
					}
					set	
					{
						cropAlgorithmCode = value;
					}
				}
			}

			public class RecognizeImage_FaceListItem
			{

				private int? leftTopX;

				private int? leftTopY;

				private int? rightBottomX;

				private int? rightBottomY;

				private float? faceQuality;

				private float? faceKeyPointQuality;

				private string feature;

				private string targetImageContent;

				private string cropAlgorithmCode;

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

				public float? FaceQuality
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

				public float? FaceKeyPointQuality
				{
					get
					{
						return faceKeyPointQuality;
					}
					set	
					{
						faceKeyPointQuality = value;
					}
				}

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

				public string TargetImageContent
				{
					get
					{
						return targetImageContent;
					}
					set	
					{
						targetImageContent = value;
					}
				}

				public string CropAlgorithmCode
				{
					get
					{
						return cropAlgorithmCode;
					}
					set	
					{
						cropAlgorithmCode = value;
					}
				}
			}
		}
	}
}
