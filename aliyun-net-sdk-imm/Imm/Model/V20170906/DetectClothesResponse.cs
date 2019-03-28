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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class DetectClothesResponse : AcsResponse
	{

		private string requestId;

		private List<DetectClothes_SuccessDetailsItem> successDetails;

		private List<DetectClothes_FailDetailsItem> failDetails;

		private List<string> srcUris;

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

		public List<DetectClothes_SuccessDetailsItem> SuccessDetails
		{
			get
			{
				return successDetails;
			}
			set	
			{
				successDetails = value;
			}
		}

		public List<DetectClothes_FailDetailsItem> FailDetails
		{
			get
			{
				return failDetails;
			}
			set	
			{
				failDetails = value;
			}
		}

		public List<string> SrcUris
		{
			get
			{
				return srcUris;
			}
			set	
			{
				srcUris = value;
			}
		}

		public class DetectClothes_SuccessDetailsItem
		{

			private string srcUri;

			private string time;

			private string getImageTime;

			private string detectTime;

			private List<DetectClothes_ClothesBoxDetailItem> clothesBoxDetail;

			public string SrcUri
			{
				get
				{
					return srcUri;
				}
				set	
				{
					srcUri = value;
				}
			}

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public string GetImageTime
			{
				get
				{
					return getImageTime;
				}
				set	
				{
					getImageTime = value;
				}
			}

			public string DetectTime
			{
				get
				{
					return detectTime;
				}
				set	
				{
					detectTime = value;
				}
			}

			public List<DetectClothes_ClothesBoxDetailItem> ClothesBoxDetail
			{
				get
				{
					return clothesBoxDetail;
				}
				set	
				{
					clothesBoxDetail = value;
				}
			}

			public class DetectClothes_ClothesBoxDetailItem
			{

				private string pUID;

				private string type;

				private float? score;

				private List<string> box;

				public string PUID
				{
					get
					{
						return pUID;
					}
					set	
					{
						pUID = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public float? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
					}
				}

				public List<string> Box
				{
					get
					{
						return box;
					}
					set	
					{
						box = value;
					}
				}
			}
		}

		public class DetectClothes_FailDetailsItem
		{

			private string srcUri;

			private string reason;

			public string SrcUri
			{
				get
				{
					return srcUri;
				}
				set	
				{
					srcUri = value;
				}
			}

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}
		}
	}
}
