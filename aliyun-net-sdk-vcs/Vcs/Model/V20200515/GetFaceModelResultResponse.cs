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
	public class GetFaceModelResultResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetFaceModelResult_Data data;

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

		public GetFaceModelResult_Data Data
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

		public class GetFaceModelResult_Data
		{

			private List<GetFaceModelResult_RecordsItem> records;

			public List<GetFaceModelResult_RecordsItem> Records
			{
				get
				{
					return records;
				}
				set	
				{
					records = value;
				}
			}

			public class GetFaceModelResult_RecordsItem
			{

				private string mustacheStyle;

				private string faceStyle;

				private int? capStyle;

				private int? skinColor;

				private float? rightBottomY;

				private float? rightBottomX;

				private int? hairStyle;

				private int? genderCode;

				private int? respiratorColor;

				private int? ethicCode;

				private int? ageLowerLimit;

				private float? leftTopY;

				private float? leftTopX;

				private int? hairColor;

				private int? ageUpLimit;

				private int? glassStyle;

				private int? glassColor;

				private int? capColor;

				private string capColorReliability;

				private string respiratorColorReliability;

				private string ethicCodeReliability;

				private string genderCodeReliability;

				private string glassColorReliability;

				private string skinColorReliability;

				private string mustacheStyleReliability;

				private string capStyleReliability;

				private string faceStyleReliability;

				private string glassStyleReliability;

				private string ageUpLimitReliability;

				private string hairStyleReliability;

				private string ageLowerLimitReliability;

				private string hairColorReliability;

				private List<string> featureData;

				public string MustacheStyle
				{
					get
					{
						return mustacheStyle;
					}
					set	
					{
						mustacheStyle = value;
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

				public int? CapStyle
				{
					get
					{
						return capStyle;
					}
					set	
					{
						capStyle = value;
					}
				}

				public int? SkinColor
				{
					get
					{
						return skinColor;
					}
					set	
					{
						skinColor = value;
					}
				}

				public float? RightBottomY
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

				public float? RightBottomX
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

				public int? HairStyle
				{
					get
					{
						return hairStyle;
					}
					set	
					{
						hairStyle = value;
					}
				}

				public int? GenderCode
				{
					get
					{
						return genderCode;
					}
					set	
					{
						genderCode = value;
					}
				}

				public int? RespiratorColor
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

				public int? EthicCode
				{
					get
					{
						return ethicCode;
					}
					set	
					{
						ethicCode = value;
					}
				}

				public int? AgeLowerLimit
				{
					get
					{
						return ageLowerLimit;
					}
					set	
					{
						ageLowerLimit = value;
					}
				}

				public float? LeftTopY
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

				public float? LeftTopX
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

				public int? HairColor
				{
					get
					{
						return hairColor;
					}
					set	
					{
						hairColor = value;
					}
				}

				public int? AgeUpLimit
				{
					get
					{
						return ageUpLimit;
					}
					set	
					{
						ageUpLimit = value;
					}
				}

				public int? GlassStyle
				{
					get
					{
						return glassStyle;
					}
					set	
					{
						glassStyle = value;
					}
				}

				public int? GlassColor
				{
					get
					{
						return glassColor;
					}
					set	
					{
						glassColor = value;
					}
				}

				public int? CapColor
				{
					get
					{
						return capColor;
					}
					set	
					{
						capColor = value;
					}
				}

				public string CapColorReliability
				{
					get
					{
						return capColorReliability;
					}
					set	
					{
						capColorReliability = value;
					}
				}

				public string RespiratorColorReliability
				{
					get
					{
						return respiratorColorReliability;
					}
					set	
					{
						respiratorColorReliability = value;
					}
				}

				public string EthicCodeReliability
				{
					get
					{
						return ethicCodeReliability;
					}
					set	
					{
						ethicCodeReliability = value;
					}
				}

				public string GenderCodeReliability
				{
					get
					{
						return genderCodeReliability;
					}
					set	
					{
						genderCodeReliability = value;
					}
				}

				public string GlassColorReliability
				{
					get
					{
						return glassColorReliability;
					}
					set	
					{
						glassColorReliability = value;
					}
				}

				public string SkinColorReliability
				{
					get
					{
						return skinColorReliability;
					}
					set	
					{
						skinColorReliability = value;
					}
				}

				public string MustacheStyleReliability
				{
					get
					{
						return mustacheStyleReliability;
					}
					set	
					{
						mustacheStyleReliability = value;
					}
				}

				public string CapStyleReliability
				{
					get
					{
						return capStyleReliability;
					}
					set	
					{
						capStyleReliability = value;
					}
				}

				public string FaceStyleReliability
				{
					get
					{
						return faceStyleReliability;
					}
					set	
					{
						faceStyleReliability = value;
					}
				}

				public string GlassStyleReliability
				{
					get
					{
						return glassStyleReliability;
					}
					set	
					{
						glassStyleReliability = value;
					}
				}

				public string AgeUpLimitReliability
				{
					get
					{
						return ageUpLimitReliability;
					}
					set	
					{
						ageUpLimitReliability = value;
					}
				}

				public string HairStyleReliability
				{
					get
					{
						return hairStyleReliability;
					}
					set	
					{
						hairStyleReliability = value;
					}
				}

				public string AgeLowerLimitReliability
				{
					get
					{
						return ageLowerLimitReliability;
					}
					set	
					{
						ageLowerLimitReliability = value;
					}
				}

				public string HairColorReliability
				{
					get
					{
						return hairColorReliability;
					}
					set	
					{
						hairColorReliability = value;
					}
				}

				public List<string> FeatureData
				{
					get
					{
						return featureData;
					}
					set	
					{
						featureData = value;
					}
				}
			}
		}
	}
}
