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
	public class RecognizePDFResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private RecognizePDF_Data data;

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

		public RecognizePDF_Data Data
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

		public class RecognizePDF_Data
		{

			private long? height;

			private long? width;

			private long? orgHeight;

			private long? orgWidth;

			private long? pageIndex;

			private long? angle;

			private List<RecognizePDF_WordsInfoItem> wordsInfo;

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

			public long? OrgHeight
			{
				get
				{
					return orgHeight;
				}
				set	
				{
					orgHeight = value;
				}
			}

			public long? OrgWidth
			{
				get
				{
					return orgWidth;
				}
				set	
				{
					orgWidth = value;
				}
			}

			public long? PageIndex
			{
				get
				{
					return pageIndex;
				}
				set	
				{
					pageIndex = value;
				}
			}

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

			public List<RecognizePDF_WordsInfoItem> WordsInfo
			{
				get
				{
					return wordsInfo;
				}
				set	
				{
					wordsInfo = value;
				}
			}

			public class RecognizePDF_WordsInfoItem
			{

				private long? angle;

				private string word;

				private long? height;

				private long? width;

				private long? x;

				private long? y;

				private List<RecognizePDF_PositionsItem> positions;

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

				public string Word
				{
					get
					{
						return word;
					}
					set	
					{
						word = value;
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

				public long? X
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

				public long? Y
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

				public List<RecognizePDF_PositionsItem> Positions
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

				public class RecognizePDF_PositionsItem
				{

					private long? x;

					private long? y;

					public long? X
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

					public long? Y
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
				}
			}
		}
	}
}
