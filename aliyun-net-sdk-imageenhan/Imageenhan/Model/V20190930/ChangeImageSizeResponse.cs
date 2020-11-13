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

namespace Aliyun.Acs.imageenhan.Model.V20190930
{
	public class ChangeImageSizeResponse : AcsResponse
	{

		private string requestId;

		private ChangeImageSize_Data data;

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

		public ChangeImageSize_Data Data
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

		public class ChangeImageSize_Data
		{

			private string url;

			private ChangeImageSize_RetainLocation retainLocation;

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public ChangeImageSize_RetainLocation RetainLocation
			{
				get
				{
					return retainLocation;
				}
				set	
				{
					retainLocation = value;
				}
			}

			public class ChangeImageSize_RetainLocation
			{

				private int? x;

				private int? y;

				private int? width;

				private int? height;

				public int? X
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

				public int? Y
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
