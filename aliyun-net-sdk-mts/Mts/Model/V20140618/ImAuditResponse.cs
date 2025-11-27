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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class ImAuditResponse : AcsResponse
	{

		private bool? textQuotaExceed;

		private bool? imageQuotaExceed;

		private string requestId;

		private ImAudit_ImageResults imageResults;

		private ImAudit_TextResults textResults;

		public bool? TextQuotaExceed
		{
			get
			{
				return textQuotaExceed;
			}
			set	
			{
				textQuotaExceed = value;
			}
		}

		public bool? ImageQuotaExceed
		{
			get
			{
				return imageQuotaExceed;
			}
			set	
			{
				imageQuotaExceed = value;
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

		public ImAudit_ImageResults ImageResults
		{
			get
			{
				return imageResults;
			}
			set	
			{
				imageResults = value;
			}
		}

		public ImAudit_TextResults TextResults
		{
			get
			{
				return textResults;
			}
			set	
			{
				textResults = value;
			}
		}

		public class ImAudit_ImageResults
		{

			private List<ImAudit_ResultItem> result;

			public List<ImAudit_ResultItem> Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
				}
			}

			public class ImAudit_ResultItem
			{

				private long? code;

				private string dataId;

				private string extras;

				private string msg;

				private string taskId;

				private string url;

				private List<ImAudit_Result> results;

				public long? Code
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

				public string DataId
				{
					get
					{
						return dataId;
					}
					set	
					{
						dataId = value;
					}
				}

				public string Extras
				{
					get
					{
						return extras;
					}
					set	
					{
						extras = value;
					}
				}

				public string Msg
				{
					get
					{
						return msg;
					}
					set	
					{
						msg = value;
					}
				}

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}

				public List<ImAudit_Result> Results
				{
					get
					{
						return results;
					}
					set	
					{
						results = value;
					}
				}

				public class ImAudit_Result
				{

					private string label;

					private double? rate;

					private string scene;

					private string suggestion;

					private List<ImAudit_HintWordsInfoItem> hintWordsInfo;

					private List<ImAudit_QrcodeLocationsItem> qrcodeLocations;

					private List<ImAudit_ProgramCodeDataItem> programCodeData;

					private List<ImAudit_LogoDataItem> logoData;

					private List<ImAudit_SfaceDataItem> sfaceData;

					private List<ImAudit_FramesItem> frames;

					private List<string> qrcodeData;

					private List<string> ocrData;

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
						}
					}

					public double? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public string Scene
					{
						get
						{
							return scene;
						}
						set	
						{
							scene = value;
						}
					}

					public string Suggestion
					{
						get
						{
							return suggestion;
						}
						set	
						{
							suggestion = value;
						}
					}

					public List<ImAudit_HintWordsInfoItem> HintWordsInfo
					{
						get
						{
							return hintWordsInfo;
						}
						set	
						{
							hintWordsInfo = value;
						}
					}

					public List<ImAudit_QrcodeLocationsItem> QrcodeLocations
					{
						get
						{
							return qrcodeLocations;
						}
						set	
						{
							qrcodeLocations = value;
						}
					}

					public List<ImAudit_ProgramCodeDataItem> ProgramCodeData
					{
						get
						{
							return programCodeData;
						}
						set	
						{
							programCodeData = value;
						}
					}

					public List<ImAudit_LogoDataItem> LogoData
					{
						get
						{
							return logoData;
						}
						set	
						{
							logoData = value;
						}
					}

					public List<ImAudit_SfaceDataItem> SfaceData
					{
						get
						{
							return sfaceData;
						}
						set	
						{
							sfaceData = value;
						}
					}

					public List<ImAudit_FramesItem> Frames
					{
						get
						{
							return frames;
						}
						set	
						{
							frames = value;
						}
					}

					public List<string> QrcodeData
					{
						get
						{
							return qrcodeData;
						}
						set	
						{
							qrcodeData = value;
						}
					}

					public List<string> OcrData
					{
						get
						{
							return ocrData;
						}
						set	
						{
							ocrData = value;
						}
					}

					public class ImAudit_HintWordsInfoItem
					{

						private string context;

						public string Context
						{
							get
							{
								return context;
							}
							set	
							{
								context = value;
							}
						}
					}

					public class ImAudit_QrcodeLocationsItem
					{

						private float? x;

						private float? y;

						private float? w;

						private float? h;

						private string qrcode;

						public float? X
						{
							get
							{
								return x;
							}
							set	
							{
								x = value;
							}
						}

						public float? Y
						{
							get
							{
								return y;
							}
							set	
							{
								y = value;
							}
						}

						public float? W
						{
							get
							{
								return w;
							}
							set	
							{
								w = value;
							}
						}

						public float? H
						{
							get
							{
								return h;
							}
							set	
							{
								h = value;
							}
						}

						public string Qrcode
						{
							get
							{
								return qrcode;
							}
							set	
							{
								qrcode = value;
							}
						}
					}

					public class ImAudit_ProgramCodeDataItem
					{

						private float? x;

						private float? y;

						private float? w;

						private float? h;

						public float? X
						{
							get
							{
								return x;
							}
							set	
							{
								x = value;
							}
						}

						public float? Y
						{
							get
							{
								return y;
							}
							set	
							{
								y = value;
							}
						}

						public float? W
						{
							get
							{
								return w;
							}
							set	
							{
								w = value;
							}
						}

						public float? H
						{
							get
							{
								return h;
							}
							set	
							{
								h = value;
							}
						}
					}

					public class ImAudit_LogoDataItem
					{

						private string type;

						private string name;

						private float? x;

						private float? y;

						private float? w;

						private float? h;

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

						public float? X
						{
							get
							{
								return x;
							}
							set	
							{
								x = value;
							}
						}

						public float? Y
						{
							get
							{
								return y;
							}
							set	
							{
								y = value;
							}
						}

						public float? W
						{
							get
							{
								return w;
							}
							set	
							{
								w = value;
							}
						}

						public float? H
						{
							get
							{
								return h;
							}
							set	
							{
								h = value;
							}
						}
					}

					public class ImAudit_SfaceDataItem
					{

						private float? x;

						private float? y;

						private float? w;

						private float? h;

						private List<ImAudit_FacesItem> faces;

						public float? X
						{
							get
							{
								return x;
							}
							set	
							{
								x = value;
							}
						}

						public float? Y
						{
							get
							{
								return y;
							}
							set	
							{
								y = value;
							}
						}

						public float? W
						{
							get
							{
								return w;
							}
							set	
							{
								w = value;
							}
						}

						public float? H
						{
							get
							{
								return h;
							}
							set	
							{
								h = value;
							}
						}

						public List<ImAudit_FacesItem> Faces
						{
							get
							{
								return faces;
							}
							set	
							{
								faces = value;
							}
						}

						public class ImAudit_FacesItem
						{

							private string name;

							private float? re;

							private string idid;

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

							public float? Re
							{
								get
								{
									return re;
								}
								set	
								{
									re = value;
								}
							}

							public string Idid
							{
								get
								{
									return idid;
								}
								set	
								{
									idid = value;
								}
							}
						}
					}

					public class ImAudit_FramesItem
					{

						private float? rate;

						private string url;

						public float? Rate
						{
							get
							{
								return rate;
							}
							set	
							{
								rate = value;
							}
						}

						public string Url
						{
							get
							{
								return url;
							}
							set	
							{
								url = value;
							}
						}
					}
				}
			}
		}

		public class ImAudit_TextResults
		{

			private List<ImAudit_ResultItem2> result1;

			public List<ImAudit_ResultItem2> Result1
			{
				get
				{
					return result1;
				}
				set	
				{
					result1 = value;
				}
			}

			public class ImAudit_ResultItem2
			{

				private long? code;

				private string content;

				private string dataId;

				private string msg;

				private string taskId;

				private List<ImAudit_Result4> results3;

				public long? Code
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

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public string DataId
				{
					get
					{
						return dataId;
					}
					set	
					{
						dataId = value;
					}
				}

				public string Msg
				{
					get
					{
						return msg;
					}
					set	
					{
						msg = value;
					}
				}

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

				public List<ImAudit_Result4> Results3
				{
					get
					{
						return results3;
					}
					set	
					{
						results3 = value;
					}
				}

				public class ImAudit_Result4
				{

					private string label;

					private double? rate;

					private string scene;

					private string suggestion;

					private List<ImAudit_DetailsItem> details;

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
						}
					}

					public double? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public string Scene
					{
						get
						{
							return scene;
						}
						set	
						{
							scene = value;
						}
					}

					public string Suggestion
					{
						get
						{
							return suggestion;
						}
						set	
						{
							suggestion = value;
						}
					}

					public List<ImAudit_DetailsItem> Details
					{
						get
						{
							return details;
						}
						set	
						{
							details = value;
						}
					}

					public class ImAudit_DetailsItem
					{

						private string label;

						private List<ImAudit_ContextsItem> contexts;

						public string Label
						{
							get
							{
								return label;
							}
							set	
							{
								label = value;
							}
						}

						public List<ImAudit_ContextsItem> Contexts
						{
							get
							{
								return contexts;
							}
							set	
							{
								contexts = value;
							}
						}

						public class ImAudit_ContextsItem
						{

							private string context;

							private string libName;

							private string libCode;

							private string ruleType;

							private List<string> positions;

							public string Context
							{
								get
								{
									return context;
								}
								set	
								{
									context = value;
								}
							}

							public string LibName
							{
								get
								{
									return libName;
								}
								set	
								{
									libName = value;
								}
							}

							public string LibCode
							{
								get
								{
									return libCode;
								}
								set	
								{
									libCode = value;
								}
							}

							public string RuleType
							{
								get
								{
									return ruleType;
								}
								set	
								{
									ruleType = value;
								}
							}

							public List<string> Positions
							{
								get
								{
									return positions;
								}
								set	
								{
									positions = value;
								}
							}
						}
					}
				}
			}
		}
	}
}
