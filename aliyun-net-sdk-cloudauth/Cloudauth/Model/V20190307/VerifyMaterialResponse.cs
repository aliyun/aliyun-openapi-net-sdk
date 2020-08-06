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

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
	public class VerifyMaterialResponse : AcsResponse
	{

		private string requestId;

		private string verifyToken;

		private int? verifyStatus;

		private float? authorityComparisionScore;

		private float? idCardFaceComparisonScore;

		private VerifyMaterial_Material material;

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

		public string VerifyToken
		{
			get
			{
				return verifyToken;
			}
			set	
			{
				verifyToken = value;
			}
		}

		public int? VerifyStatus
		{
			get
			{
				return verifyStatus;
			}
			set	
			{
				verifyStatus = value;
			}
		}

		public float? AuthorityComparisionScore
		{
			get
			{
				return authorityComparisionScore;
			}
			set	
			{
				authorityComparisionScore = value;
			}
		}

		public float? IdCardFaceComparisonScore
		{
			get
			{
				return idCardFaceComparisonScore;
			}
			set	
			{
				idCardFaceComparisonScore = value;
			}
		}

		public VerifyMaterial_Material Material
		{
			get
			{
				return material;
			}
			set	
			{
				material = value;
			}
		}

		public class VerifyMaterial_Material
		{

			private string faceImageUrl;

			private string idCardName;

			private string idCardNumber;

			private string faceQuality;

			private string faceGlobalUrl;

			private string faceMask;

			private VerifyMaterial_IdCardInfo idCardInfo;

			public string FaceImageUrl
			{
				get
				{
					return faceImageUrl;
				}
				set	
				{
					faceImageUrl = value;
				}
			}

			public string IdCardName
			{
				get
				{
					return idCardName;
				}
				set	
				{
					idCardName = value;
				}
			}

			public string IdCardNumber
			{
				get
				{
					return idCardNumber;
				}
				set	
				{
					idCardNumber = value;
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

			public string FaceGlobalUrl
			{
				get
				{
					return faceGlobalUrl;
				}
				set	
				{
					faceGlobalUrl = value;
				}
			}

			public string FaceMask
			{
				get
				{
					return faceMask;
				}
				set	
				{
					faceMask = value;
				}
			}

			public VerifyMaterial_IdCardInfo IdCardInfo
			{
				get
				{
					return idCardInfo;
				}
				set	
				{
					idCardInfo = value;
				}
			}

			public class VerifyMaterial_IdCardInfo
			{

				private string number;

				private string address;

				private string nationality;

				private string endDate;

				private string frontImageUrl;

				private string authority;

				private string sex;

				private string name;

				private string birth;

				private string backImageUrl;

				private string startDate;

				public string Number
				{
					get
					{
						return number;
					}
					set	
					{
						number = value;
					}
				}

				public string Address
				{
					get
					{
						return address;
					}
					set	
					{
						address = value;
					}
				}

				public string Nationality
				{
					get
					{
						return nationality;
					}
					set	
					{
						nationality = value;
					}
				}

				public string EndDate
				{
					get
					{
						return endDate;
					}
					set	
					{
						endDate = value;
					}
				}

				public string FrontImageUrl
				{
					get
					{
						return frontImageUrl;
					}
					set	
					{
						frontImageUrl = value;
					}
				}

				public string Authority
				{
					get
					{
						return authority;
					}
					set	
					{
						authority = value;
					}
				}

				public string Sex
				{
					get
					{
						return sex;
					}
					set	
					{
						sex = value;
					}
				}

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

				public string Birth
				{
					get
					{
						return birth;
					}
					set	
					{
						birth = value;
					}
				}

				public string BackImageUrl
				{
					get
					{
						return backImageUrl;
					}
					set	
					{
						backImageUrl = value;
					}
				}

				public string StartDate
				{
					get
					{
						return startDate;
					}
					set	
					{
						startDate = value;
					}
				}
			}
		}
	}
}
