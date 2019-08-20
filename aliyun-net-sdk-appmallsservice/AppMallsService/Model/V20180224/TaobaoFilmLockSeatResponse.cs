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
	public class TaobaoFilmLockSeatResponse : AcsResponse
	{

		private string errorCode;

		private string msg;

		private string subCode;

		private string subMsg;

		private string logsId;

		private string requestId;

		private TaobaoFilmLockSeat_SeatLocked seatLocked;

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

		public TaobaoFilmLockSeat_SeatLocked SeatLocked
		{
			get
			{
				return seatLocked;
			}
			set	
			{
				seatLocked = value;
			}
		}

		public class TaobaoFilmLockSeat_SeatLocked
		{

			private string applyKey;

			private long? defaultLockSecond;

			private long? lockTime;

			private string status;

			public string ApplyKey
			{
				get
				{
					return applyKey;
				}
				set	
				{
					applyKey = value;
				}
			}

			public long? DefaultLockSecond
			{
				get
				{
					return defaultLockSecond;
				}
				set	
				{
					defaultLockSecond = value;
				}
			}

			public long? LockTime
			{
				get
				{
					return lockTime;
				}
				set	
				{
					lockTime = value;
				}
			}

			public string Status
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
		}
	}
}
