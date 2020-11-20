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
	public class RecognizePoiNameResponse : AcsResponse
	{

		private string requestId;

		private RecognizePoiName_Data data;

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

		public RecognizePoiName_Data Data
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

		public class RecognizePoiName_Data
		{

			private List<RecognizePoiName_SignboardsItem> signboards;

			private RecognizePoiName_Summary summary;

			public List<RecognizePoiName_SignboardsItem> Signboards
			{
				get
				{
					return signboards;
				}
				set	
				{
					signboards = value;
				}
			}

			public RecognizePoiName_Summary Summary
			{
				get
				{
					return summary;
				}
				set	
				{
					summary = value;
				}
			}

			public class RecognizePoiName_SignboardsItem
			{

				private List<RecognizePoiName_TextsItem> texts;

				public List<RecognizePoiName_TextsItem> Texts
				{
					get
					{
						return texts;
					}
					set	
					{
						texts = value;
					}
				}

				public class RecognizePoiName_TextsItem
				{

					private string label;

					private float? score;

					private string tag;

					private string type;

					private List<string> points;

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

					public string Tag
					{
						get
						{
							return tag;
						}
						set	
						{
							tag = value;
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

					public List<string> Points
					{
						get
						{
							return points;
						}
						set	
						{
							points = value;
						}
					}
				}
			}

			public class RecognizePoiName_Summary
			{

				private string brand;

				private float? score;

				public string Brand
				{
					get
					{
						return brand;
					}
					set	
					{
						brand = value;
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
			}
		}
	}
}
