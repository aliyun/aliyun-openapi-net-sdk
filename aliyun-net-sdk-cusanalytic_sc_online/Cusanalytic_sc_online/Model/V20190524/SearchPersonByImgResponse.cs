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

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
	public class SearchPersonByImgResponse : AcsResponse
	{

		private bool? success;

		private string msg;

		private List<SearchPersonByImg_PersonSearchResultItem> personSearchResultItems;

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

		public List<SearchPersonByImg_PersonSearchResultItem> PersonSearchResultItems
		{
			get
			{
				return personSearchResultItems;
			}
			set	
			{
				personSearchResultItems = value;
			}
		}

		public class SearchPersonByImg_PersonSearchResultItem
		{

			private string faceId;

			private string ukId;

			private float? score;

			public string FaceId
			{
				get
				{
					return faceId;
				}
				set	
				{
					faceId = value;
				}
			}

			public string UkId
			{
				get
				{
					return ukId;
				}
				set	
				{
					ukId = value;
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
