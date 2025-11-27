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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class ListCustomPersonsResponse : AcsResponse
	{

		private string requestId;

		private List<ListCustomPersons_Category> categories;

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

		public List<ListCustomPersons_Category> Categories
		{
			get
			{
				return categories;
			}
			set	
			{
				categories = value;
			}
		}

		public class ListCustomPersons_Category
		{

			private string categoryId;

			private string categoryName;

			private string categoryDescription;

			private List<ListCustomPersons_Person> persons;

			public string CategoryId
			{
				get
				{
					return categoryId;
				}
				set	
				{
					categoryId = value;
				}
			}

			public string CategoryName
			{
				get
				{
					return categoryName;
				}
				set	
				{
					categoryName = value;
				}
			}

			public string CategoryDescription
			{
				get
				{
					return categoryDescription;
				}
				set	
				{
					categoryDescription = value;
				}
			}

			public List<ListCustomPersons_Person> Persons
			{
				get
				{
					return persons;
				}
				set	
				{
					persons = value;
				}
			}

			public class ListCustomPersons_Person
			{

				private string personName;

				private string personDescription;

				private string personId;

				private List<ListCustomPersons_Face> faces;

				public string PersonName
				{
					get
					{
						return personName;
					}
					set	
					{
						personName = value;
					}
				}

				public string PersonDescription
				{
					get
					{
						return personDescription;
					}
					set	
					{
						personDescription = value;
					}
				}

				public string PersonId
				{
					get
					{
						return personId;
					}
					set	
					{
						personId = value;
					}
				}

				public List<ListCustomPersons_Face> Faces
				{
					get
					{
						return faces;
					}
					set	
					{
						faces = value;
					}
				}

				public class ListCustomPersons_Face
				{

					private string imageUrl;

					private string faceId;

					public string ImageUrl
					{
						get
						{
							return imageUrl;
						}
						set	
						{
							imageUrl = value;
						}
					}

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
				}
			}
		}
	}
}
