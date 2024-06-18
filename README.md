The OAuth Login API is explained in full detail in this document and details an authentication process as well as the granting of JWT token access to various regions of a mobile game as allowed by the roles and permissions granted to the user requesting access.

Key Features
⦁	User Authentication: This is a system that requires the users to enter their username and password to log in.
⦁	JWT Token: Emits a JWT token that contains the “roles” of the user and the “regions” the user has visibility on.
⦁	Role-based Access Control: Manages rights to the game features in case of certain user’s roles and in certain regions.

API Endpoints
1.	POST /api/auth/login: Registers a user and creates a JWT token for the user in return.
2.	GET /api/game/b_game: Connects to the default game region seen by all users after they sign in and enter the application.
3.	GET /api/game/vip_character_personalize: Runs a query and retrieves data from the more secure section where only authorized user roles can access.

System Roles and Regions
⦁	Roles: 
	  -> player
	  -> admin
⦁	Regions:
		-> b_game (which is set for all the users as default).
		-> vip_character_personalize (allows users who pay the VIP fee to use it).
