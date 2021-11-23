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
	public class RecognizeVideoCharacterResponse : AcsResponse
	{

		private string requestId;

		private RecognizeVideoCharacter_Data data;

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

		public RecognizeVideoCharacter_Data Data
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

		public class RecognizeVideoCharacter_Data
		{

			private long? width;

			private long? height;

			private List<RecognizeVideoCharacter_Frame> frames;

			public long? Width
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

			public long? Height
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

			public List<RecognizeVideoCharacter_Frame> Frames
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

			public class RecognizeVideoCharacter_Frame
			{

				private long? timestamp;

				private List<RecognizeVideoCharacter_Element> elements;

				public long? Timestamp
				{
					get
					{
						return timestamp;
					}
					set	
					{
						timestamp = value;
					}
				}

				public List<RecognizeVideoCharacter_Element> Elements
				{
					get
					{
						return elements;
					}
					set	
					{
						elements = value;
					}
				}

				public class RecognizeVideoCharacter_Element
				{

					private float? score;

					private string text;

					private List<RecognizeVideoCharacter_TextRectangle> textRectangles;

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

					public List<RecognizeVideoCharacter_TextRectangle> TextRectangles
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

					public class RecognizeVideoCharacter_TextRectangle
					{

						private long? angle;

						private long? left;

						private long? top;

						private long? width;

						private long? height;

						public long? Angle
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

						public long? Left
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

						public long? Top
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

						public long? Width
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

						public long? Height
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
}
