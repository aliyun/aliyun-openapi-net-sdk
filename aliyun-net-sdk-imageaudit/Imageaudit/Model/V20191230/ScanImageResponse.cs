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

namespace Aliyun.Acs.imageaudit.Model.V20191230
{
	public class ScanImageResponse : AcsResponse
	{

		private string requestId;

		private ScanImage_Data data;

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

		public ScanImage_Data Data
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

		public class ScanImage_Data
		{

			private List<ScanImage_Result> results;

			public List<ScanImage_Result> Results
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

			public class ScanImage_Result
			{

				private string taskId;

				private string dataId;

				private string imageURL;

				private List<ScanImage_SubResult> subResults;

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

				public string ImageURL
				{
					get
					{
						return imageURL;
					}
					set	
					{
						imageURL = value;
					}
				}

				public List<ScanImage_SubResult> SubResults
				{
					get
					{
						return subResults;
					}
					set	
					{
						subResults = value;
					}
				}

				public class ScanImage_SubResult
				{

					private string suggestion;

					private float? rate;

					private string label;

					private string scene;

					private List<ScanImage_Frame> frames;

					private List<ScanImage_SfaceData> sfaceDataList;

					private List<ScanImage_HintWordsInfo> hintWordsInfoList;

					private List<ScanImage_LogoData> logoDataList;

					private List<ScanImage_ProgramCodeData> programCodeDataList;

					private List<string> oCRDataList;

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

					public List<ScanImage_Frame> Frames
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

					public List<ScanImage_SfaceData> SfaceDataList
					{
						get
						{
							return sfaceDataList;
						}
						set	
						{
							sfaceDataList = value;
						}
					}

					public List<ScanImage_HintWordsInfo> HintWordsInfoList
					{
						get
						{
							return hintWordsInfoList;
						}
						set	
						{
							hintWordsInfoList = value;
						}
					}

					public List<ScanImage_LogoData> LogoDataList
					{
						get
						{
							return logoDataList;
						}
						set	
						{
							logoDataList = value;
						}
					}

					public List<ScanImage_ProgramCodeData> ProgramCodeDataList
					{
						get
						{
							return programCodeDataList;
						}
						set	
						{
							programCodeDataList = value;
						}
					}

					public List<string> OCRDataList
					{
						get
						{
							return oCRDataList;
						}
						set	
						{
							oCRDataList = value;
						}
					}

					public class ScanImage_Frame
					{

						private float? rate;

						private string uRL;

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

						public string URL
						{
							get
							{
								return uRL;
							}
							set	
							{
								uRL = value;
							}
						}
					}

					public class ScanImage_SfaceData
					{

						private float? x;

						private float? y;

						private float? height;

						private float? width;

						private List<ScanImage_Face> faces;

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

						public float? Height
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

						public float? Width
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

						public List<ScanImage_Face> Faces
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

						public class ScanImage_Face
						{

							private float? rate;

							private string id;

							private string name;

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

							public string Id
							{
								get
								{
									return id;
								}
								set	
								{
									id = value;
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
						}
					}

					public class ScanImage_HintWordsInfo
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

					public class ScanImage_LogoData
					{

						private string type;

						private float? x;

						private float? y;

						private float? height;

						private float? width;

						private string name;

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

						public float? Height
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

						public float? Width
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
					}

					public class ScanImage_ProgramCodeData
					{

						private float? x;

						private float? y;

						private float? height;

						private float? width;

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

						public float? Height
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

						public float? Width
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
					}
				}
			}
		}
	}
}
