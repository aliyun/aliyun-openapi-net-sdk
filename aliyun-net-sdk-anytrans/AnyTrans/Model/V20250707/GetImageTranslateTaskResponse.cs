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

namespace Aliyun.Acs.AnyTrans.Model.V20250707
{
	public class GetImageTranslateTaskResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private string httpStatusCode;

		private bool? synchro;

		private GetImageTranslateTask_Data data;

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "HttpStatusCode")]
		public string HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		[JsonProperty(PropertyName = "Synchro")]
		public bool? Synchro
		{
			get
			{
				return synchro;
			}
			set	
			{
				synchro = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public GetImageTranslateTask_Data Data
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

		public class GetImageTranslateTask_Data
		{

			private string traceId;

			private GetImageTranslateTask_Translation translation;

			[JsonProperty(PropertyName = "TraceId")]
			public string TraceId
			{
				get
				{
					return traceId;
				}
				set	
				{
					traceId = value;
				}
			}

			[JsonProperty(PropertyName = "Translation")]
			public GetImageTranslateTask_Translation Translation
			{
				get
				{
					return translation;
				}
				set	
				{
					translation = value;
				}
			}

			public class GetImageTranslateTask_Translation
			{

				private long? angle;

				private long? width;

				private long? height;

				private long? orgWidth;

				private long? orgHeight;

				private long? boxesCount;

				private List<GetImageTranslateTask_BoundingBoxesItem> boundingBoxes;

				private List<GetImageTranslateTask_TableInfosItem> tableInfos;

				[JsonProperty(PropertyName = "Angle")]
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

				[JsonProperty(PropertyName = "Width")]
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

				[JsonProperty(PropertyName = "Height")]
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

				[JsonProperty(PropertyName = "OrgWidth")]
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

				[JsonProperty(PropertyName = "OrgHeight")]
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

				[JsonProperty(PropertyName = "BoxesCount")]
				public long? BoxesCount
				{
					get
					{
						return boxesCount;
					}
					set	
					{
						boxesCount = value;
					}
				}

				[JsonProperty(PropertyName = "BoundingBoxes")]
				public List<GetImageTranslateTask_BoundingBoxesItem> BoundingBoxes
				{
					get
					{
						return boundingBoxes;
					}
					set	
					{
						boundingBoxes = value;
					}
				}

				[JsonProperty(PropertyName = "TableInfos")]
				public List<GetImageTranslateTask_TableInfosItem> TableInfos
				{
					get
					{
						return tableInfos;
					}
					set	
					{
						tableInfos = value;
					}
				}

				public class GetImageTranslateTask_BoundingBoxesItem
				{

					private float? confidence;

					private string text;

					private long? direction;

					private long? tableId;

					private long? tableCellId;

					private string translation;

					private GetImageTranslateTask_UpLeft upLeft;

					private GetImageTranslateTask_UpRight upRight;

					private GetImageTranslateTask_DownLeft downLeft;

					private GetImageTranslateTask_DownRight downRight;

					[JsonProperty(PropertyName = "Confidence")]
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

					[JsonProperty(PropertyName = "Text")]
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

					[JsonProperty(PropertyName = "Direction")]
					public long? Direction
					{
						get
						{
							return direction;
						}
						set	
						{
							direction = value;
						}
					}

					[JsonProperty(PropertyName = "TableId")]
					public long? TableId
					{
						get
						{
							return tableId;
						}
						set	
						{
							tableId = value;
						}
					}

					[JsonProperty(PropertyName = "TableCellId")]
					public long? TableCellId
					{
						get
						{
							return tableCellId;
						}
						set	
						{
							tableCellId = value;
						}
					}

					[JsonProperty(PropertyName = "Translation")]
					public string Translation
					{
						get
						{
							return translation;
						}
						set	
						{
							translation = value;
						}
					}

					[JsonProperty(PropertyName = "UpLeft")]
					public GetImageTranslateTask_UpLeft UpLeft
					{
						get
						{
							return upLeft;
						}
						set	
						{
							upLeft = value;
						}
					}

					[JsonProperty(PropertyName = "UpRight")]
					public GetImageTranslateTask_UpRight UpRight
					{
						get
						{
							return upRight;
						}
						set	
						{
							upRight = value;
						}
					}

					[JsonProperty(PropertyName = "DownLeft")]
					public GetImageTranslateTask_DownLeft DownLeft
					{
						get
						{
							return downLeft;
						}
						set	
						{
							downLeft = value;
						}
					}

					[JsonProperty(PropertyName = "DownRight")]
					public GetImageTranslateTask_DownRight DownRight
					{
						get
						{
							return downRight;
						}
						set	
						{
							downRight = value;
						}
					}

					public class GetImageTranslateTask_UpLeft
					{

						private long? x;

						private long? y;

						[JsonProperty(PropertyName = "X")]
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

						[JsonProperty(PropertyName = "Y")]
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

					public class GetImageTranslateTask_UpRight
					{

						private long? x;

						private long? y;

						[JsonProperty(PropertyName = "X")]
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

						[JsonProperty(PropertyName = "Y")]
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

					public class GetImageTranslateTask_DownLeft
					{

						private long? x;

						private long? y;

						[JsonProperty(PropertyName = "X")]
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

						[JsonProperty(PropertyName = "Y")]
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

					public class GetImageTranslateTask_DownRight
					{

						private long? x;

						private long? y;

						[JsonProperty(PropertyName = "X")]
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

						[JsonProperty(PropertyName = "Y")]
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

				public class GetImageTranslateTask_TableInfosItem
				{

					private long? tableId;

					private long? xCellSize;

					private long? yCellSize;

					private List<GetImageTranslateTask_CellInfosItem> cellInfos;

					[JsonProperty(PropertyName = "TableId")]
					public long? TableId
					{
						get
						{
							return tableId;
						}
						set	
						{
							tableId = value;
						}
					}

					[JsonProperty(PropertyName = "XCellSize")]
					public long? XCellSize
					{
						get
						{
							return xCellSize;
						}
						set	
						{
							xCellSize = value;
						}
					}

					[JsonProperty(PropertyName = "YCellSize")]
					public long? YCellSize
					{
						get
						{
							return yCellSize;
						}
						set	
						{
							yCellSize = value;
						}
					}

					[JsonProperty(PropertyName = "CellInfos")]
					public List<GetImageTranslateTask_CellInfosItem> CellInfos
					{
						get
						{
							return cellInfos;
						}
						set	
						{
							cellInfos = value;
						}
					}

					public class GetImageTranslateTask_CellInfosItem
					{

						private long? tableCellId;

						private string text;

						private long? xsc;

						private long? xec;

						private long? ysc;

						private long? yec;

						private List<GetImageTranslateTask_PosItem> pos;

						[JsonProperty(PropertyName = "TableCellId")]
						public long? TableCellId
						{
							get
							{
								return tableCellId;
							}
							set	
							{
								tableCellId = value;
							}
						}

						[JsonProperty(PropertyName = "Text")]
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

						[JsonProperty(PropertyName = "Xsc")]
						public long? Xsc
						{
							get
							{
								return xsc;
							}
							set	
							{
								xsc = value;
							}
						}

						[JsonProperty(PropertyName = "Xec")]
						public long? Xec
						{
							get
							{
								return xec;
							}
							set	
							{
								xec = value;
							}
						}

						[JsonProperty(PropertyName = "Ysc")]
						public long? Ysc
						{
							get
							{
								return ysc;
							}
							set	
							{
								ysc = value;
							}
						}

						[JsonProperty(PropertyName = "Yec")]
						public long? Yec
						{
							get
							{
								return yec;
							}
							set	
							{
								yec = value;
							}
						}

						[JsonProperty(PropertyName = "Pos")]
						public List<GetImageTranslateTask_PosItem> Pos
						{
							get
							{
								return pos;
							}
							set	
							{
								pos = value;
							}
						}

						public class GetImageTranslateTask_PosItem
						{

							private long? x;

							private long? y;

							[JsonProperty(PropertyName = "X")]
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

							[JsonProperty(PropertyName = "Y")]
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
	}
}
