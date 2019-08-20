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

namespace Aliyun.Acs.AppMallsService.Model.V20180224
{
	public class TaobaoFilmGetSeatsResponse : AcsResponse
	{

		private string errorCode;

		private string msg;

		private string subCode;

		private string subMsg;

		private string logsId;

		private string requestId;

		private TaobaoFilmGetSeats_SeatMap seatMap;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public string SubCode
		{
			get
			{
				return subCode;
			}
			set	
			{
				subCode = value;
			}
		}

		public string SubMsg
		{
			get
			{
				return subMsg;
			}
			set	
			{
				subMsg = value;
			}
		}

		public string LogsId
		{
			get
			{
				return logsId;
			}
			set	
			{
				logsId = value;
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

		public TaobaoFilmGetSeats_SeatMap SeatMap
		{
			get
			{
				return seatMap;
			}
			set	
			{
				seatMap = value;
			}
		}

		public class TaobaoFilmGetSeats_SeatMap
		{

			private long? maxCanBuy;

			private long? maxColumn;

			private long? maxLeftPx;

			private long? maxRow;

			private long? maxTopPx;

			private long? minColumn;

			private long? minLeftPx;

			private long? minRow;

			private long? minTopPx;

			private string notice;

			private bool? regular;

			private long? seatCount;

			private long? soldCount;

			private string tipMessage;

			private List<TaobaoFilmGetSeats_SeatsItem> seats;

			public long? MaxCanBuy
			{
				get
				{
					return maxCanBuy;
				}
				set	
				{
					maxCanBuy = value;
				}
			}

			public long? MaxColumn
			{
				get
				{
					return maxColumn;
				}
				set	
				{
					maxColumn = value;
				}
			}

			public long? MaxLeftPx
			{
				get
				{
					return maxLeftPx;
				}
				set	
				{
					maxLeftPx = value;
				}
			}

			public long? MaxRow
			{
				get
				{
					return maxRow;
				}
				set	
				{
					maxRow = value;
				}
			}

			public long? MaxTopPx
			{
				get
				{
					return maxTopPx;
				}
				set	
				{
					maxTopPx = value;
				}
			}

			public long? MinColumn
			{
				get
				{
					return minColumn;
				}
				set	
				{
					minColumn = value;
				}
			}

			public long? MinLeftPx
			{
				get
				{
					return minLeftPx;
				}
				set	
				{
					minLeftPx = value;
				}
			}

			public long? MinRow
			{
				get
				{
					return minRow;
				}
				set	
				{
					minRow = value;
				}
			}

			public long? MinTopPx
			{
				get
				{
					return minTopPx;
				}
				set	
				{
					minTopPx = value;
				}
			}

			public string Notice
			{
				get
				{
					return notice;
				}
				set	
				{
					notice = value;
				}
			}

			public bool? Regular
			{
				get
				{
					return regular;
				}
				set	
				{
					regular = value;
				}
			}

			public long? SeatCount
			{
				get
				{
					return seatCount;
				}
				set	
				{
					seatCount = value;
				}
			}

			public long? SoldCount
			{
				get
				{
					return soldCount;
				}
				set	
				{
					soldCount = value;
				}
			}

			public string TipMessage
			{
				get
				{
					return tipMessage;
				}
				set	
				{
					tipMessage = value;
				}
			}

			public List<TaobaoFilmGetSeats_SeatsItem> Seats
			{
				get
				{
					return seats;
				}
				set	
				{
					seats = value;
				}
			}

			public class TaobaoFilmGetSeats_SeatsItem
			{

				private string area;

				private long? column;

				private string extId;

				private long? flag;

				private long? leftPx;

				private string name;

				private long? row;

				private string rowName;

				private long? status;

				private long? topPx;

				public string Area
				{
					get
					{
						return area;
					}
					set	
					{
						area = value;
					}
				}

				public long? Column
				{
					get
					{
						return column;
					}
					set	
					{
						column = value;
					}
				}

				public string ExtId
				{
					get
					{
						return extId;
					}
					set	
					{
						extId = value;
					}
				}

				public long? Flag
				{
					get
					{
						return flag;
					}
					set	
					{
						flag = value;
					}
				}

				public long? LeftPx
				{
					get
					{
						return leftPx;
					}
					set	
					{
						leftPx = value;
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

				public long? Row
				{
					get
					{
						return row;
					}
					set	
					{
						row = value;
					}
				}

				public string RowName
				{
					get
					{
						return rowName;
					}
					set	
					{
						rowName = value;
					}
				}

				public long? Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public long? TopPx
				{
					get
					{
						return topPx;
					}
					set	
					{
						topPx = value;
					}
				}
			}
		}
	}
}
