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
	public class RecognizeCharacterResponse : AcsResponse
	{

		private string requestId;

		private RecognizeCharacter_Data data;

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

		public RecognizeCharacter_Data Data
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

		public class RecognizeCharacter_Data
		{

			private List<RecognizeCharacter_Result> results;

			public List<RecognizeCharacter_Result> Results
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

			public class RecognizeCharacter_Result
			{

				private float? probability;

				private string text;

				private RecognizeCharacter_TextRectangles textRectangles;

				public float? Probability
				{
					get
					{
						return probability;
					}
					set	
					{
						probability = value;
					}
				}

				public string Text
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

				public RecognizeCharacter_TextRectangles TextRectangles
				{
					get
					{
						return textRectangles;
					}
					set	
					{
						textRectangles = value;
					}
				}

				public class RecognizeCharacter_TextRectangles
				{

					private int? angle;

					private int? left;

					private int? top;

					private int? width;

					private int? height;

					public int? Angle
					{
						get
						{
							return angle;
						}
						set	
						{
							angle = value;
						}
					}

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
			}
		}
	}
}
