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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class CheckLoaFillResponse : AcsResponse
	{

		private string requestId;

		private CheckLoaFill_Data data;

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

		public CheckLoaFill_Data Data
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

		public class CheckLoaFill_Data
		{

			private bool? stampFill;

			private bool? addressFill;

			private bool? tradeMarkNameFill;

			private bool? countryFill;

			private bool? nationalityFill;

			private bool? materialNameFill;

			private string templateUrl;

			private List<string> errorMsgs;

			public bool? StampFill
			{
				get
				{
					return stampFill;
				}
				set	
				{
					stampFill = value;
				}
			}

			public bool? AddressFill
			{
				get
				{
					return addressFill;
				}
				set	
				{
					addressFill = value;
				}
			}

			public bool? TradeMarkNameFill
			{
				get
				{
					return tradeMarkNameFill;
				}
				set	
				{
					tradeMarkNameFill = value;
				}
			}

			public bool? CountryFill
			{
				get
				{
					return countryFill;
				}
				set	
				{
					countryFill = value;
				}
			}

			public bool? NationalityFill
			{
				get
				{
					return nationalityFill;
				}
				set	
				{
					nationalityFill = value;
				}
			}

			public bool? MaterialNameFill
			{
				get
				{
					return materialNameFill;
				}
				set	
				{
					materialNameFill = value;
				}
			}

			public string TemplateUrl
			{
				get
				{
					return templateUrl;
				}
				set	
				{
					templateUrl = value;
				}
			}

			public List<string> ErrorMsgs
			{
				get
				{
					return errorMsgs;
				}
				set	
				{
					errorMsgs = value;
				}
			}
		}
	}
}
