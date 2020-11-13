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
	public class RecognizeTrainTicketResponse : AcsResponse
	{

		private string requestId;

		private RecognizeTrainTicket_Data data;

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

		public RecognizeTrainTicket_Data Data
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

		public class RecognizeTrainTicket_Data
		{

			private string date;

			private string destination;

			private string level;

			private string number;

			private string name;

			private string departureStation;

			private string seat;

			private float? price;

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
				}
			}

			public string Destination
			{
				get
				{
					return destination;
				}
				set	
				{
					destination = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public string Number
			{
				get
				{
					return number;
				}
				set	
				{
					number = value;
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

			public string DepartureStation
			{
				get
				{
					return departureStation;
				}
				set	
				{
					departureStation = value;
				}
			}

			public string Seat
			{
				get
				{
					return seat;
				}
				set	
				{
					seat = value;
				}
			}

			public float? Price
			{
				get
				{
					return price;
				}
				set	
				{
					price = value;
				}
			}
		}
	}
}
