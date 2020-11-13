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

namespace Aliyun.Acs.ocr.Model.V20191230
{
	public class RecognizeStampResponse : AcsResponse
	{

		private string requestId;

		private RecognizeStamp_Data data;

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

		public RecognizeStamp_Data Data
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

		public class RecognizeStamp_Data
		{

			private List<RecognizeStamp_ResultsItem> results;

			public List<RecognizeStamp_ResultsItem> Results
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

			public class RecognizeStamp_ResultsItem
			{

				private List<RecognizeStamp_GeneralTextItem> generalText;

				private RecognizeStamp_Roi roi;

				private RecognizeStamp_Text text;

				public List<RecognizeStamp_GeneralTextItem> GeneralText
				{
					get
					{
						return generalText;
					}
					set	
					{
						generalText = value;
					}
				}

				public RecognizeStamp_Roi Roi
				{
					get
					{
						return roi;
					}
					set	
					{
						roi = value;
					}
				}

				public RecognizeStamp_Text Text
				{
					get
					{
						return text;
					}
					set	
					{
						text = value;
					}
				}

				public class RecognizeStamp_GeneralTextItem
				{

					private string content;

					private float? confidence;

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

					public float? Confidence
					{
						get
						{
							return confidence;
						}
						set	
						{
							confidence = value;
						}
					}
				}

				public class RecognizeStamp_Roi
				{

					private int? left;

					private int? top;

					private int? width;

					private int? height;

					public int? Left
					{
						get
						{
							return left;
						}
						set	
						{
							left = value;
						}
					}

					public int? Top
					{
						get
						{
							return top;
						}
						set	
						{
							top = value;
						}
					}

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
				}

				public class RecognizeStamp_Text
				{

					private string content;

					private float? confidence;

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

					public float? Confidence
					{
						get
						{
							return confidence;
						}
						set	
						{
							confidence = value;
						}
					}
				}
			}
		}
	}
}
